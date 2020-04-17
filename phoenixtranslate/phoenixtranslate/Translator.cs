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
        public int currentRow;
        public string ActivateTraslate = string.Empty;
        public string textesource;
        public string textescible = "";
        public string textescibleold;
        public GeckoWebBrowser wb1 => geckoWebBrowser1;

        public Translator()
        {
            InitializeComponent();
            Gecko.Xpcom.Initialize("Firefox");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Properties.Settings.Default.Name_Translator.Clear();
            //Properties.Settings.Default.Save();
            if (Properties.Settings.Default.Name_Translator.Cast<string>().ToArray().Length == 0)
            {
                Properties.Settings.Default.index = -1;
                Properties.Settings.Default.Save();
            }
            else
            {

                geckoWebBrowser1.Navigate(Properties.Settings.Default.Link[Properties.Settings.Default.index].ToString());

            }
            dataGridView1.Rows.Add("home", "");
            dataGridView1.Rows.Add("car", "");
            //MessageBox.Show(Properties.Settings.Default.index.ToString());
        }
        protected override void OnClosed(EventArgs e)
        {
            geckoWebBrowser1.Dispose();
            Xpcom.Shutdown();
            base.OnClosed(e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.index != -1)
            {
                if (Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index] != string.Empty)
                {
                    fill(wb1, (Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index]),(Properties.Settings.Default.Querysender[Properties.Settings.Default.index]), dataGridView1.CurrentCell.Value.ToString());
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.index != -1)
            {
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = Extract(wb1, Properties.Settings.Default.Xpathreceiver[Properties.Settings.Default.index], "text");
                currentRow = dataGridView1.SelectedRows[0].Index;
                if (currentRow < dataGridView1.RowCount - 1)
                {
                    dataGridView1.Rows[++currentRow].Cells[0].Selected = true;
                }
                else
                {
                    MessageBox.Show("Fin.", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        public string Extract(GeckoWebBrowser wb, string xpath, string type)
        {
            string result = string.Empty;
            GeckoHtmlElement Elm;

            if (wb != null)
            {
                Elm = (GeckoHtmlElement)wb.Document.EvaluateXPath(xpath).GetNodes().FirstOrDefault();

                if (Elm != null)
                {
                    switch (type)
                    {
                        case "html":

                            result = Elm.OuterHtml;
                            break;

                        case "text":

                            if (Elm.GetType().Name == "GeckoTextAreaElement")
                                result = ((GeckoTextAreaElement)Elm).Value;
                            else
                                result = Elm.TextContent.Trim();
                            break;

                        case "value":

                            result = ((GeckoInputElement)Elm).Value;
                            break;

                        default:

                            result = ExtractData(Elm, type);
                            break;
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
        public void fill(GeckoWebBrowser wb, string xpath, string Query, string value)
        {
            if (wb != null)
            {
                GeckoHtmlElement elm = (GeckoHtmlElement)wb.Document.EvaluateXPath(xpath).GetNodes().FirstOrDefault();

                if (elm != null)
                {
                   
                    GeckoTextAreaElement input1 = (GeckoTextAreaElement)elm;
                   
                    if (Query != "#fakeArea")
                    {
                        input1.Value = value;
                        var evt = wb.Document.CreateEvent("HTMLEvents");
                        using (Gecko.AutoJSContext java = new Gecko.AutoJSContext(wb.Window))
                        {
                            var selector = Query;
                            java.EvaluateScript($@"
                        var xpathResult = document.querySelector('{selector}') 
                        var evt = document.createEvent('HTMLEvents');
                        evt.initEvent('change', false, true);
                        xpathResult.dispatchEvent(evt);
                        ", out string outString);
                        }
                    }
                  else
                    {
                        input1.Value = "";
                        wb.Focus();
                        //input1.Focus();
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
        private void Translator_FormClosing(object sender, FormClosingEventArgs e){timer1.Enabled = false;}
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.index != -1)
            {
                if (Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index] != string.Empty)
                {
                    currentRow = dataGridView1.SelectedRows[0].Index;
                    fill(wb1, (Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index]),(Properties.Settings.Default.Querysender[Properties.Settings.Default.index]), dataGridView1.Rows[currentRow].Cells[0].Value.ToString());
                }
            }
        }
        private void geckoWebBrowser1_ShowContextMenu(object sender, GeckoContextMenuEventArgs e) { this.contextMenuwb1.Show(Control.MousePosition); }

        private void geckoWebBrowser1_Navigated(object sender, GeckoNavigatedEventArgs e)
        {

        }

        private void geckoWebBrowser1_DocumentCompleted(object sender, GeckoDocumentCompletedEventArgs e)
        {
          
            if (Properties.Settings.Default.index != -1)
            {
                if (Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index] != string.Empty)
                {
                    wait(1000);
                    fill(wb1, (Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index]),(Properties.Settings.Default.Querysender[Properties.Settings.Default.index]), dataGridView1.CurrentCell.Value.ToString());
                }
            }
        }
    }
}
