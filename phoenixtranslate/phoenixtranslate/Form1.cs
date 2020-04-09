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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            geckoWebBrowser1.Navigate("https://www.deepl.com/translator");
           
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
            GeckoHtmlElement elm = null/* TODO Change to default(_) if this is not a reference type */;

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
    }
}
