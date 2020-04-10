using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Gecko;
using Gecko.DOM;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.Text;

namespace phoenixtranslate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            geckoWebBrowser1.Navigate("https://www.deepl.com/translator");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
         
        }
        public string Extract(string xpath, string type)
        {
            string result = string.Empty;
            GeckoHtmlElement Elm;
            GeckoWebBrowser wb = geckoWebBrowser1;

            if (wb != null)
            {
                Elm = GetElement(wb, xpath);

            if (Elm != null)
            {
                if (Elm != null)
                {
                    switch (type)
                    {
                        case "html":
                            {
                                result = Elm.OuterHtml;
                                break;
                            }

                        case "text":
                            {
                                if (Elm.GetType().Name == "GeckoTextAreaElement")
                                    result = ((GeckoTextAreaElement)Elm).Value;
                                else
                                    result = Elm.TextContent.Trim();
                                break;
                            }

                        case "value":
                            {
                                result = ((GeckoInputElement)Elm).Value;
                                break;
                            }

                        default:
                            {
                                result = ExtractData(Elm, type);
                                break;
                            }
                    }
                }
            }
        }

        return result;
        }
        private string ExtractData(GeckoHtmlElement ele, string attribute)
        {
            var result = string.Empty;

            if (ele != null)
            {
                var tmp = ele.GetAttribute(attribute);
                if (tmp != null)
                    result = tmp.Trim();
            }

            return result;
        }

        private GeckoHtmlElement GetElement(GeckoWebBrowser wb, string xpath)
        {

            GeckoHtmlElement elm = null;

            if (xpath.StartsWith("/"))
            {
                if (xpath.Contains("@class") || xpath.Contains("@data-type"))
                {
                    var html = GetHtmlFromGeckoDocument(wb.Document);
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(html);
                    var node = doc.DocumentNode.SelectSingleNode(xpath);

                    if (node != null)
                    {
                        var currentXpath = "/" + node.XPath;
                        elm = (GeckoHtmlElement)wb.Document.EvaluateXPath(currentXpath).GetNodes().FirstOrDefault();
                    }
                }
                else
                    elm = (GeckoHtmlElement)wb.Document.EvaluateXPath(xpath).GetNodes().FirstOrDefault();
            }
            else
                elm = (GeckoHtmlElement)wb.Document.GetElementById(xpath);

            return elm;
        }

        private string GetHtmlFromGeckoDocument(GeckoDocument doc)
        {
            var result = string.Empty;
            GeckoHtmlElement element;
            var geckoDomElement = doc.DocumentElement;

            if (geckoDomElement is GeckoHtmlElement)
            {
                element = (GeckoHtmlElement)geckoDomElement;
                result = element.InnerHtml;
            }

            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {

         
            fill("/html[1]/body[1]/div[2]/div[1]/div[1]/div[3]/div[2]/div[1]/textarea[1]", textBox1.Text);
            wait(5000);//a changer
          
          textBox2.Text = Extract("/html[1]/body[1]/div[2]/div[1]/div[1]/div[4]/div[3]/div[1]/textarea[1]", "text");
        }
        public void fill(string xpath, string value)
        {
            GeckoWebBrowser wb = geckoWebBrowser1;
            if (wb != null)
            {
                if (xpath.StartsWith("/"))
                {
                    GeckoHtmlElement elm = GetElement(wb, xpath);
                    if (elm != null)
                    {
               
                  
                                GeckoTextAreaElement input1 = (GeckoTextAreaElement)elm;
                                input1.Value = "";
                                input1.Focus();
                                input1.Click();
                                Clipboard.SetText(value);
                                geckoWebBrowser1.Paste();
                     
                    }
                
                
                }
            }

        }

        public void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            //Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                //Console.WriteLine("stop wait timer");
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
