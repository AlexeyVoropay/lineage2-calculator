using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Encodings.Web;
using System.Web;
using HtmlAgilityPack;
using L2on.Data;

namespace TestConsole
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Нужен для поддержки кодировки 1251 в Core версии
            //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var myItems = L2onData.GetAllItems();
            foreach (var item in myItems)
            {
                Console.WriteLine(item.GetString());
            }

            Console.ReadKey();
        }

    }
}
