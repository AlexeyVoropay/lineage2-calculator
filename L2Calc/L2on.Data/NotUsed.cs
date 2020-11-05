using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace L2on.Data
{
    public static class NotUsed
    {
        //Конвертирует строку из UTF-8 в Windows-1251
        static string ASCIIToWin1251(string sourceStr)
        {
            Encoding utf8 = Encoding.ASCII;
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            byte[] utf8Bytes = utf8.GetBytes(sourceStr);
            byte[] win1251Bytes = Encoding.Convert(utf8, win1251, utf8Bytes);
            return win1251.GetString(win1251Bytes);
        }

        //Конвертирует строку из UTF-8 в Windows-1251
        static string UTF8ToWin1251(string sourceStr)
        {
            Encoding utf8 = Encoding.UTF8;
            Encoding win1251 = Encoding.GetEncoding("Windows-1251");
            byte[] utf8Bytes = utf8.GetBytes(sourceStr);
            byte[] win1251Bytes = Encoding.Convert(utf8, win1251, utf8Bytes);
            return win1251.GetString(win1251Bytes);
        }

        //Конвертирует строку из Windows-1251 в UTF-8
        static private string Win1251ToUTF8(string source)
        {
            Encoding utf8 = Encoding.GetEncoding("utf-8");
            Encoding win1251 = Encoding.GetEncoding("windows-1251");
            byte[] utf8Bytes = win1251.GetBytes(source);
            byte[] win1251Bytes = Encoding.Convert(win1251, utf8, utf8Bytes);
            source = win1251.GetString(win1251Bytes);
            return source;
        }

        public static string GetHtmlOldVersion()
        {
            string htmlCode = null;
            using (WebClient client = new WebClient())
            {
                //option value = "3054" selected = "" > Cherry </
                client.Encoding = Encoding.GetEncoding(1251);
                //var site = @"https://www.ulmart.ru";
                //WebClient client = new WebClient();
                //WebRequest request = WebRequest.Create(site);
                //var response = request.GetResponse();
                //client.Headers.Add(HttpRequestHeader.ContentType, response.ContentType);
                //string htmlCode = client.DownloadString(site);
                //var url = "http://l2on.net/?c=market&a=pulse&q=&type=book&setworld=3054";
                var url = "http://l2on.net/?c=market&a=pulse&q=&type=armor&grade=B&armor=magic&part=0&setworld=3054";
                htmlCode = client.DownloadString(url);
            }
            return htmlCode;
        }
    }
}
