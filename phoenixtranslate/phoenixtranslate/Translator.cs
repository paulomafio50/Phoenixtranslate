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
using Gecko.Events;

namespace phoenixtranslate
{

    public partial class Translator : Form
    {
        //remetre droit ctrl+K et D
        public string ActivateTraslate = string.Empty;
        public string textesource;
        public string textescible = "";
        public string textescibleold;
        public GeckoWebBrowser wb1 => geckoWebBrowser1;

        public Translator()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            geckoWebBrowser1.Navigate(Properties.Settings.Default.Link[Properties.Settings.Default.index].ToString());
        }
        protected override void OnClosed(EventArgs e)
        {
            geckoWebBrowser1.Dispose();
            Xpcom.Shutdown();
            base.OnClosed(e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fill(wb1, (Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index]), textBox1.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = Extract(wb1, Properties.Settings.Default.Xpathreceiver[Properties.Settings.Default.index], "text");
        }
        public string Extract(GeckoWebBrowser wb, string xpath, string type)
        {
            string result = string.Empty;
            GeckoHtmlElement Elm;


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



        public void fill(GeckoWebBrowser wb, string xpath, string value)
        {

            if (wb != null)
            {
                if (xpath.StartsWith("/"))
                {
                    GeckoHtmlElement elm = GetElement(wb, xpath);
                    if (elm != null)
                    {
                        GeckoTextAreaElement input1 = (GeckoTextAreaElement)elm;
                        input1.Value = "";
                        wb.Focus();
                        input1.Focus();
                        if (value != "")
                        {
                            SendKeys.Send(value);
                        }
                    }
                }
            }
        }

        public void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void buttontranslatorconfig_Click(object sender, EventArgs e)
        {
            Translator_config translator_config = new Translator_config(this);
            translator_config.ShowDialog();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActivateTraslate = Extract(wb1, Properties.Settings.Default.Xpathreceiver[Properties.Settings.Default.index], "text");

            if (ActivateTraslate == string.Empty)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void Translator_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void geckoWebBrowser1_ShowContextMenu(object sender, GeckoContextMenuEventArgs e)
        {
            contextMenuStrip1.Show((Control)sender, e.Location);
      

        }
    }
}
