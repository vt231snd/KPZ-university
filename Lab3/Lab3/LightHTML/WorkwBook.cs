using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;
using Lab3.LightHTML.Node;

namespace Lab3.LightHTML
{
    public class WorkwBook
    {
        public async Task<LightElementNode> ParseBookAsync(string url)
        {
            string bookText = await DownloadBookTextAsync(url);
            return ParseTextToHtml(bookText);
        }

        private async Task<string> DownloadBookTextAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                return await client.GetStringAsync(url);
            }
        }

        private LightElementNode ParseTextToHtml(string text)
        {
            var lines = text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
            var root = new LightElementNode("div", ViewType.Block, CloseType.Normal); 

            bool firstLine = true;

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                LightElementNode el;

                if (firstLine)
                {
                    el = new LightElementNode("h1", ViewType.Block, CloseType.Normal); 
                    firstLine = false;
                }
                else if (line.Length < 20)
                {
                    el = new LightElementNode("h2", ViewType.Block, CloseType.Normal); 
                }
                else if (char.IsWhiteSpace(line[0]))
                {
                    el = new LightElementNode("blockquote", ViewType.Block, CloseType.Normal); 
                }
                else
                {
                    el = new LightElementNode("p", ViewType.Block, CloseType.Normal); 
                }

                el.AddChild(new LightTextNode(line)); 
                root.AddChild(el);
            }

            return root;
        }
    }
}
