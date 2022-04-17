using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace WinFormsCrawler
{
    class SimpleCrawler
    {
        public Action<String> GetUrlInfo;
        public Hashtable urls { get; set; } = new Hashtable();
        private int count = 0;
        private string root;
        public SimpleCrawler()
        {
            
        }

        public void Crawl(string s)
        {
            root = "";
            urls.Clear();
            if (s == "") s = "http://www.cnblogs.com/dstang2000/";
            urls.Add(s, false);
            bool firstNode = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '.' && !firstNode) continue;
                if (s[i] == '.' && firstNode) break;
                firstNode = true;
                root += s[i];
            }
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    if (!Regex.IsMatch(url, root)) continue;//判断是否带有根
                    current = url;
                }
                if (current == null || count > 10) break;
                GetUrlInfo(current);
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html, current);//解析,并加入新的链接
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                GetUrlInfo($" : success\n");
                return html;
            }
            catch (Exception ex)
            {
                GetUrlInfo($" : {ex.Message}\n");
                return "";
            }
        }

        private void Parse(string html, string basepath)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (!Legal(strRef)) continue;
                if (strRef.Length == 0) continue;
                if (IsRelative(strRef)) strRef = ToAbsolutePath(basepath, strRef);
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
        private bool Legal(string URL)
        {
            if (Regex.IsMatch(URL, @"\.(html|hml|aspx|jsp)")) return true;
            if (Regex.IsMatch(URL, @"/[^.]+$")) return true;
            return false;
        }
        private bool IsRelative(string URL)
        {
            if (Regex.IsMatch(URL, @"(http|https)")) return false;
            return true;
        }
        private string ToAbsolutePath(string basePath, string relativePath)
        {
            return new Uri(new Uri(basePath), relativePath).ToString();//如果是文件路径将/替换为\
        }
    }
}
