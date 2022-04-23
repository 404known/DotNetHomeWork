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
using System.Collections.Concurrent;

namespace WinFormsCrawler
{
    class SimpleCrawler
    {
        public Action<String> GetUrlInfo;
        public ConcurrentDictionary<string, bool> urls { get; set; } = new ConcurrentDictionary<string, bool>();
        public ConcurrentQueue<string> urlsQueue { get; set; } = new ConcurrentQueue<string>();
        private int count = 0;
        private string root;
        public SimpleCrawler()
        {
            
        }

        public void Crawl(object Url)
        {
            string s = (string)Url;
            root = "";
            urls.Clear();
            urlsQueue.Clear();
            if (s == "") s = "http://www.cnblogs.com/dstang2000/";
            urls.TryAdd(s, false);
            urlsQueue.Enqueue(s);
            Uri uri = new Uri(s);
            root = uri.Host;
            while (urls.Count < 10)
            {
                if(urlsQueue.Count >= 0)
                {
                    string current;
                    urlsQueue.TryDequeue(out current);
                    if (current == null) continue;
                    urls[current] = true;
                    Task<string> task1 = Task.Run(() => DownLoad(current));
                    count++;
                    Task task2 = task1.ContinueWith(t => { Parse(t.Result, current); });
                }
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
                GetUrlInfo($"{url} : success\n");
                return html;
            }
            catch (Exception ex)
            {
                GetUrlInfo($"{url} : {ex.Message}\n");
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
                if (strRef == null || strRef == "" || strRef.StartsWith("javascript:")) continue;
                strRef = ToAbsolutePath(basepath, strRef);
                Match linkUrlMatch = Regex.Match(strRef, @"^(?<site>(?<protocal>https?)://(?<host>[\w\d.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)");
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (!Regex.IsMatch(host, root)||!Regex.IsMatch(file, ".(html?|aspx|jsp|php)$|^[^.]*$"))continue;
                bool isAdded;
                urls.TryGetValue(strRef,out isAdded);
                if (isAdded != true)
                {
                    urls.TryAdd(strRef, false);
                    urlsQueue.Enqueue(strRef);
                }
            }
        }
        private string ToAbsolutePath(string basePath, string relativePath)
        {
            if (relativePath.Contains("://")) return relativePath;
            return new Uri(new Uri(basePath), relativePath).ToString();
        }
    }
}
