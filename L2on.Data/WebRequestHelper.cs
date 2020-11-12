using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
//using System.Web;
//using System.Web.Configuration;

namespace L2Calc
{
    public static class WebRequestHelper
    {
        public static string GetResponseString(string url, string method, string body = null, string contentType = null, 
            Dictionary<string, string> headers = null, Encoding encodingForStream = null)
        {
            var request = WebRequest.Create(url);
            //request.Headers[HttpRequestHeader.AcceptEncoding] = "gzip, deflate";            
            request.Method = method;
            request.ContentType = String.IsNullOrEmpty(contentType) ? "application/x-www-form-urlencoded" : contentType;            
            if (!String.IsNullOrEmpty(body))
            {
                using (var requestStream = request.GetRequestStream())
                using (var writer = new StreamWriter(requestStream))
                {
                    writer.Write(body);
                }
            }
            else
            {
                request.ContentLength = 0;
            }
            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }
            using (var response = request.GetResponse())
            {
                if (encodingForStream != null)
                {
                    using (StreamReader streamReader = new StreamReader(response.GetResponseStream(), encodingForStream))
                    {
                        return streamReader.ReadToEnd().Trim();
                    }
                }
                else
                {
                    using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        return streamReader.ReadToEnd().Trim();
                    }
                }
            }
        }

        /// <summary>
        /// Gets response html string for selected url.
        /// </summary>
        /// <param name="url">Request url.</param>
        /// <param name="encoding">Encoding of requested website.</param>
        /// <returns>String containing html response.</returns>
        public static string GetResponseString(string url)
        {
            using (HttpWebResponse response = GetResponse(url))
            {
                return GetResponseString(response, Encoding.UTF8);
            }
        }

        /// <summary>
        /// Gets response html string for selected url.
        /// </summary>
        /// <param name="url">Request url.</param>
        /// <param name="encoding">Encoding of requested website.</param>
        /// <returns>String containing html response.</returns>
        public static T GetResponseItem<T>(string url)
        {
            using (HttpWebResponse response = GetResponse(url))
            {
                var jsonResponse = GetResponseString(response, Encoding.UTF8);
                return JsonConvert.DeserializeObject<T>(jsonResponse);
            }
        }

        /// <summary>
        /// Gets response html string for selected url.
        /// </summary>
        /// <param name="url">Request url.</param>
        /// <param name="encoding">Encoding of requested website.</param>
        /// <returns>String containing html response.</returns>
        public static string GetResponseString(string url, Encoding encoding)
        {
            using (HttpWebResponse response = GetResponse(url))
            {
                return GetResponseString(response, encoding);
            }
        }

        /// <summary>
        /// Gets response html string from web response.
        /// </summary>
        /// <param name="response">Web response.</param>
        /// <param name="encoding">Encoding of requested website.</param>
        /// <returns>String containing html response.</returns>
        public static string GetResponseString(WebResponse response, Encoding encoding)
        {
            string result;
            Stream resStream = response.GetResponseStream();
            if (resStream == null)
            {
                return null;
            }
            using (var buffer = new BufferedStream(resStream))
            {
                using (var reader = new StreamReader(buffer, encoding))
                {
                    result = reader.ReadToEnd();
                }
            }
            response.Dispose();
            return result;
        }

        /// <summary>
        /// Gets web response for selected site.
        /// </summary>
        /// <param name="url">Request url</param>
        /// <param name="headers">Request headers.</param>
        /// <param name="cookies">Request cookies.</param>
        /// <returns>Http web response.</returns>
        public static HttpWebResponse GetResponse(string url, Dictionary<string, string> headers = null, Cookie[] cookies = null, bool allowAutoRedirect = true)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            ServicePointManager.UseNagleAlgorithm = false;
            request.Method = WebRequestMethods.Http.Get;
            WebRequest.DefaultWebProxy = null;
            request.Proxy = WebRequest.DefaultWebProxy;
            request.AllowAutoRedirect = allowAutoRedirect;
            request.KeepAlive = false;
            request.CookieContainer = new CookieContainer();
            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }
            if (cookies != null)
            {
                foreach (var cookie in cookies)
                {
                    request.CookieContainer.Add(cookie);
                }
            }
            request.ProtocolVersion = new Version(1, 1);
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.57 Safari/537.36";
            return (HttpWebResponse)request.GetResponse();

        }

        /// <summary>
        /// Gets response for Post request.
        /// </summary>
        /// <param name="url">Request url.</param>
        /// <param name="requestBody">Request body.</param>
        /// <returns>Http web response.</returns>
        public static HttpWebResponse GetPostResponse(string url, string requestBody, Dictionary<string, string> headers = null)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.KeepAlive = false;
            request.Method = WebRequestMethods.Http.Post;
            request.ContentType = "application/json";
            using (var requestStream = request.GetRequestStream())
            using (var writer = new StreamWriter(requestStream))
            {
                writer.Write(requestBody);
            }
            request.CookieContainer = new CookieContainer();
            request.KeepAlive = false;
            request.UserAgent =
                "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/30.0.1599.101 Safari/537.36";
            request.ProtocolVersion = new Version(1, 1);
            request.AllowAutoRedirect = false;
            if (headers != null)
            {
                foreach (var header in headers)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }
            try
            {
                var a = (HttpWebResponse)request.GetResponse();
                return a;
            }
            catch (WebException ex)
            {
                WebResponse response = ex.Response;
                Stream resStream = response.GetResponseStream();
                string a;
                if (resStream == null)
                {
                    return null;
                }
                using (var buffer = new BufferedStream(resStream))
                {
                    using (var reader = new StreamReader(buffer))
                    {
                        a = reader.ReadToEnd();
                    }
                }
                throw;
            }

        }


        //public static bool IsAllowedReferredRequest()
        //{
        //    if (HttpContext.Current == null || HttpContext.Current.Request.UrlReferrer == null)
        //    {
        //        return false;
        //    }

        //    var referredDnsName = HttpContext.Current.Request.UrlReferrer.DnsSafeHost.ToUpperInvariant();

        //    if (WebConfigurationManager.AppSettings["DEV"] == "true" && referredDnsName == "LOCALHOST")
        //        return true;

        //    return referredDnsName.EndsWith("SOCIALBOARDS.NO") || 
        //        referredDnsName.EndsWith("SOCIALBOARDS.COM") ||
        //        referredDnsName.EndsWith("HUDDLY.COM");
        //}

        public static string GetResponseString(string url, Dictionary<string, string> header, Encoding encoding, bool allowAutoRedirect = true)
        {
            return GetResponseString(GetResponse(url, header, allowAutoRedirect: allowAutoRedirect), encoding);
        }
    }
}