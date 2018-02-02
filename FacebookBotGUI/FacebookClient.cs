using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace FacebookBotGUI
{
    class FacebookClient
    {
        private CookieContainer cookieContainer;
        private string fb_dtsg;

        public bool IsLogged { get; private set; } = false;
        public string ProfileName { get; private set; } = "";
        public string ProfileId { get; private set; } = "";


        public FacebookClient()
        {
            cookieContainer = new CookieContainer();
        }

        public Dictionary<string,string> GetOnlineUsers()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            string html = GetHtmlSourceCode("https://m.facebook.com/buddylist.php?ref_component=mbasic_home_header&ref_page=%2Fwap%2Fhome.php&refid=8");

            MatchCollection match = Regex.Matches(html, $"fbid=(?:(?!fbid=))(.*?)&amp;click_type=buddylist#fua\">(.*?)</a>", RegexOptions.Singleline);
            foreach (Match item in match)
            {
                dict.Add(item.Groups[1].Value,item.Groups[2].Value);
            }
            return dict;

        }
        public async Task<bool> LogIn(string username, string password)
        {
            cookieContainer = new CookieContainer();
            Uri target = new Uri("https://facebook.com");
            cookieContainer.Add(new Cookie("locale", "cs-CZ") { Domain = target.Host });
            cookieContainer.Add(new Cookie("dpr", "1.2000000476837158") { Domain = target.Host });
            cookieContainer.Add(new Cookie("_js_reg_fb_ref", "https%3A%2F%2Fwww.facebook.com%2F") { Domain = target.Host });
            cookieContainer.Add(new Cookie("wd", "1600x789") { Domain = target.Host });

            string postData =($"lsd=AVrSlkGE&email={username}&pass={password}&timezone=-60&lgndim=eyJ3IjoxNjAwLCJoIjo5MDAsImF3IjoxNjAwLCJhaCI6ODY3LCJjIjoyNH0%3D&lgnrnd=003143_g2fL&lgnjs=1514968306&ab_test_data=AAAAAA%2FAAfAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA%2F%2FAAAAAACAAA&locale=cs_CZ&login_source=login_bluebar&prefill_contact_point=hacker-shade%40seznam.cz&prefill_source=last_login&prefill_type=contact_point&skstamp=eyJyb3VuZHMiOjUsInNlZWQiOiI2NmFjZDE4MDUxNTk5YWMwZjMxN2ExMTMxNjcxMzJmNiIsInNlZWQyIjoiNTEzZDI3NTg3MDUyODRkMjAwOGZjNjc5N2YzYTkzMTAiLCJoYXNoIjoiNWJlNzgyMzJiNWZiMjE0OTBhYWU2OGI1ZGNiNDhmNTAiLCJoYXNoMiI6IjNmN2YyZTUyYjJjNTkxMWYxMDQ0YzE3MTFhM2ZhYTM0IiwidGltZV90YWtlbiI6NjU1OSwic3VyZmFjZSI6ImxvZ2luIn0%3D");

            WebResponse response = await SendPostRequest("https://www.facebook.com/login.php?login_attempt=1", postData);

            if (!response.ResponseUri.OriginalString.Contains("https://www.facebook.com/login.php"))
            {
                response.Close();
                GetMyProfileData();
                IsLogged = true;
                return IsLogged;
            }
            else
            {
                response.Close();
                return false;
            }
        }
        public async void SendMessage(string userId, string msg)
        {
            string postData;
            if(userId == ProfileId)
                postData = ($"fb_dtsg={fb_dtsg}&body={msg}&send=Poslat&tids=cid.c.{ProfileId}&wwwupp=C3&ids%5B{userId}%5D={userId}&referrer=&ctype=&cver=legacy&csid=3cbdaf17-b8f1-233d-8f59-66fdfa969dc9");
            else
                postData = ($"fb_dtsg={fb_dtsg}&body={msg}&send=Poslat&tids=cid.c.{ProfileId}:{userId}&wwwupp=C3&ids%5B{userId}%5D={userId}&referrer=&ctype=&cver=legacy&csid=3cbdaf17-b8f1-233d-8f59-66fdfa969dc9");
            WebResponse response = await SendPostRequest("https://m.facebook.com/messages/send/?icm=1&refid=12", postData);
            response.Close();
        }

        private void GetMyProfileData()
        {
            string html = GetHtmlSourceCode("https://facebook.com/me");
            // ProfileId = Regex.Match(html, @"&amp;id=(\d*)&amp;").Groups[1].Value;
            ProfileId = Regex.Match(html, "referrer_profile_id=(\\d*)").Groups[1].Value;
            ProfileName = Regex.Match(html, "<title id=\"pageTitle\">(.*?)</title>").Groups[1].Value;
            fb_dtsg = Regex.Match(html, "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;

        }
        private async Task<WebResponse> SendPostRequest(string url, string postData)
        {
            byte[] data = Encoding.UTF8.GetBytes(postData);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.CookieContainer = cookieContainer;
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:57.0) Gecko/20100101 Firefox/57.0";
            request.Method = "POST";
            request.AllowWriteStreamBuffering = true;
            request.ProtocolVersion = HttpVersion.Version11;
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (Stream stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            } //Pošle request
            return await request.GetResponseAsync();
        }
        private string GetHtmlSourceCode(string url)
        {
            string html;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = cookieContainer;
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:57.0) Gecko/20100101 Firefox/57.0";

            Stream responseStream = request.GetResponse().GetResponseStream();

            using (StreamReader reader = new StreamReader(responseStream))
                html = reader.ReadToEnd();
            return html;
        }
    }
}
