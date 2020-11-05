using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using HtmlAgilityPack;
using L2Calc;
using L2Calc.Common;
using L2Calc.Common.Enums;
using L2on.Data.Models;

namespace L2on.Data
{
    public static class L2onData
    {
        public static string GetHtmlByFindString(string searchString)
        {
            var encodedSearchString = HttpUtility.UrlEncode(searchString, Encoding.GetEncoding(1251))
                .ToUpper();
            string url = $"http://l2on.net/?c=market&a=pulse&q={encodedSearchString}&type=0";
            string body = null;// JsonConvert.SerializeObject(item);
            var headers = new Dictionary<string, string>
            {
                { "Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9" },
                //{ "Accept-Encoding", "gzip, deflate" },
                { "Accept-Language", "ru-RU,ru;q=0.9" },
                { "Connection", "keep-alive" },
                { "Cookie", "PHPSESSID=rg84icf1kke5atfgat97ek9p00; __utma=150494059.331779395.1603395652.1603395652.1603395652.1; __utmc=150494059; __utmz=150494059.1603395652.1.1.utmcsr=(direct)|utmccn=(direct)|utmcmd=(none); __utmt=1; __utmb=150494059.2.10.1603395652; world=45" },
                { "Host", "l2on.net" },
                //{ "Referer", $"http://l2on.net/?c=market&a=pulse&q={encodedSearchString}&type=0" },
                { "Upgrade-Insecure-Requests", "1" },
                { "User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.111 Safari/537.36" },
            };
            string jsonResponse = WebRequestHelper.GetResponseString(url, "GET", body, "application/json", headers, Encoding.GetEncoding(1251));
            return jsonResponse;
            //return JsonConvert.DeserializeObject<Catalog>(jsonResponse);
        }
        
        public static void Start()
        {
            var myItems = GetVenirsTalismans();
            foreach (var item in myItems)
            {
                Console.WriteLine(item.GetString());
            }
        }

        /// <summary>
        /// Получение талисманов Бенира
        /// </summary>
        public static IEnumerable<MyItem> GetVenirsTalismans()
        {
            //Нужен для поддержки кодировки 1251 в Core версии
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var htmlCode = GetHtmlByFindString("бенир");
            //var htmlCode = GetHtmlOldVersion();
            var doc = new HtmlDocument();
            doc.LoadHtml(htmlCode);
            return GetGroupItems(doc, "group_armor");
        }

        /// <summary>
        /// Получение талисманов Бенира
        /// </summary>
        public static IEnumerable<MyItem> GetAllItems()
        {
            //Нужен для поддержки кодировки 1251 в Core версии
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var htmlCode = GetHtmlByFindString("");
            //var htmlCode = GetHtmlOldVersion();
            var doc = new HtmlDocument();
            doc.LoadHtml(htmlCode);
            var result = new List<MyItem>();
            result.AddRange(GetGroupItems(doc, "group_recipe"));
            result.AddRange(GetGroupItems(doc, "group_book"));
            result.AddRange(GetGroupItems(doc, "group_weapon"));
            result.AddRange(GetGroupItems(doc, "group_weapon_common"));
            result.AddRange(GetGroupItems(doc, "group_armor"));
            result.AddRange(GetGroupItems(doc, "group_jewel"));
            result.AddRange(GetGroupItems(doc, "group_jewel_common"));
            result.AddRange(GetGroupItems(doc, "group_other"));
            result = result.Where(x => x.Percent < -50).ToList();
            return result;
        }

        public static PriceType GetPriceType(string itemId, long price)
        {
            var item = ItemsTable.GetItem(itemId);
            if (item == null)
                return PriceType.None;
            if (item.GreenPrice < price)
                return PriceType.Green;
            if (item.RedPrice > price)
                return PriceType.Red;
            return PriceType.Yellow;
        }

            public static IEnumerable<MyItem> GetGroupItems(HtmlDocument htmlDocument, string nodeName)
        {
            HtmlNode group = htmlDocument.GetElementbyId(nodeName);
            if (group == null)
                return new MyItem[0];
            HtmlNode specificNode001 = group.SelectSingleNode("table");

            //HtmlNode specificNode001 = doc.DocumentNode.SelectSingleNode("table");
            HtmlNode specificNode002 = specificNode001.SelectSingleNode("tbody");
            var items = specificNode002.SelectNodes("tr");
            var myItems = new List<MyItem>();
            foreach (var item in items)
            {
                var fields = item.SelectNodes("td");
                var percent = string.Empty;
                long price = 0;
                if (fields[2].HasAttributes)
                {
                    percent = fields[2].GetAttributeValue("title", string.Empty);
                    var priceStringValue = fields[2].GetAttributeValue("data-i", string.Empty);
                    price = long.TryParse(priceStringValue, out long priceLong) ? priceLong : 0;
                }
                var id = fields[1].SelectSingleNode("span/a").GetAttributeValue("data-item", string.Empty);
                var myPrice = MyPrices.GetPrices().FirstOrDefault(x => x.Key == id).Value;
                var myItem = new MyItem
                {
                    Image = fields[0].SelectSingleNode("img").GetAttributeValue("src", string.Empty),
                    Id = fields[1].SelectSingleNode("span/a").GetAttributeValue("data-item", string.Empty),
                    Name = fields[1].SelectSingleNode("span/a").InnerHtml,
                    Price = price,
                    PriceText = fields[2].InnerHtml,
                    PriceType = GetPriceType(id, price),
                    MyPrice = myPrice,
                    MyPriceText = myPrice.ToString(),
                    Percent = !string.IsNullOrWhiteSpace(percent) 
                        ? double.Parse(percent.Replace("%", ""))
                        : (double?)null,
                    Other = fields[3].InnerHtml,
                    SpottedTime = fields[4].InnerHtml,
                };
                myItems.Add(myItem);
            }
            return myItems.OrderBy(x => x.Id);
        }
    }
}
