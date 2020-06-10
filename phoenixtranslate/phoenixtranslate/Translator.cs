using Gecko;
using Gecko.DOM;
using Gecko.Events;
using Microsoft.VisualBasic;
using phoenixtranslate.Properties;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.XPath;

namespace phoenixtranslate
{
    public partial class Translator : Form
    {

        //remetre droit ctrl+K et D
        public Boolean StatutSave = true;
        public string Path = "";
        public int currentRow;
        public string ActivateTraslate = string.Empty;
        public string textesource;
        public string textescible = "";
        public string textescibleold = "old";
        public string Etatauto = "activate";
        public bool panelleftopen = true;
        public GeckoWebBrowser Wb1 => GeckoWebBrowser;
        public DataSet Dt;
        public Translator()
        {
            InitializeComponent();
            Gecko.Xpcom.Initialize("Firefox");
            InitializeComboBox();
            InitializedataGridViewTagName();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RadioButtonSearch1.Checked = true;
            TextBoxsearch.Visible = false;
            BtnNEXT.Visible = false;
            Panelleft.Width = 40;
            Paneltraducteur.Width += 260;
            Paneltraducteur.Location = new Point(40, 27);
            //panelleft.Width = 15;
            if (Properties.Settings.Default.Name_Translator.Cast<string>().ToArray().Length == 0)
            {
                Properties.Settings.Default.index = -1;
                Properties.Settings.Default.Save();
            }
            else
            {

                GeckoWebBrowser.Navigate(Properties.Settings.Default.Link[Properties.Settings.Default.index].ToString());
            }
            TabControltextbox.SelectedTab = TabTarget;
            CheckBoxAuto.Checked = true;
        }
        protected override void OnClosed(EventArgs e)
        {
            GeckoWebBrowser.Dispose();
            Xpcom.Shutdown();
            base.OnClosed(e);
        }
        private void BtnTranslate_Click(object sender, EventArgs e)
        {
            BtnTranslate.Enabled = false;
            BtnTranslate.UseWaitCursor = true;
            CheckBoxAuto.Checked = true;
            //if (CheckBoxAuto.Checked == false)
            //{
            //    CheckBoxAuto.Checked = true;
            CheckBoxAuto_Verif();
            currentRow = DataGridView.SelectedRows[0].Index;
            //    Fill(DataGridView.Rows[currentRow].Cells[0].Value.ToString());
            //    BtnTranslate.Enabled = true;
            //    BtnTranslate.UseWaitCursor = false;
            //    Timer1.Enabled = true;
            //    return;
            //}

            if (Properties.Settings.Default.index != -1)
            {
                string texttranslated = Extract(Wb1, Properties.Settings.Default.Xpathreceiver[Properties.Settings.Default.index], "text");

                if (texttranslated == null)
                {
                    MessageBox.Show(Resources.error_incorrect_config);
                    Timer1.Enabled = false;
                }
                else
                {
                    if (texttranslated.Contains(@""""))
                    {
                        texttranslated = texttranslated.Replace(@"""", @"");
                        MessageBox.Show(Resources.messagequotationremove);
                    }

                    int a = 0;
                    foreach (string item in Properties.Settings.Default.CharacterName)
                    {
                        if (texttranslated.Contains(item))
                        {
                            texttranslated = texttranslated.Replace(item, Properties.Settings.Default.CharacterTag[a]);
                        }
                        a += 1;
                    }
                    foreach (string item in Properties.Settings.Default.ListTag)
                    {
                        if (DataGridView.CurrentRow.Cells[0].Value.ToString().StartsWith(item))
                        {
                            texttranslated = texttranslated.Insert(0, item);
                        }
                        if (DataGridView.CurrentRow.Cells[0].Value.ToString().EndsWith(item))
                        {
                            texttranslated = texttranslated.Insert(texttranslated.Length, item);
                        }
                    }
                    DataGridView.Rows[DataGridView.CurrentRow.Index].Cells[1].Value = texttranslated;
                    RefreshCellResult();
                    foreach (string item in Properties.Settings.Default.ListTag)
                    {
                        if (DataGridView.CurrentRow.Cells[0].Value.ToString().Contains(item))
                        {
                            int count = new Regex(Regex.Escape(item)).Matches(DataGridView.CurrentRow.Cells[0].Value.ToString()).Count;
                            int count2 = new Regex(Regex.Escape(item)).Matches(DataGridView.CurrentRow.Cells[1].Value.ToString()).Count;
                            if (count != count2)
                            {
                                DataGridView.CurrentRow.Cells[1].Style.BackColor = Color.DarkBlue;
                            }
                        }
                    }
                    Doublon(DataGridView.CurrentRow);
                    if (DataGridView.SelectedRows[0].Index < DataGridView.RowCount - 1)
                    {
                        if (DataGridView.Rows[currentRow + 1].DefaultCellStyle.BackColor == Color.Yellow)
                        {
                            while (DataGridView.Rows[currentRow + 1].DefaultCellStyle.BackColor == Color.Yellow)
                            {
                                currentRow += 1;
                                if (DataGridView.RowCount == currentRow)
                                {
                                    break;
                                }
                            }
                        }
                        DataGridView.Rows[++currentRow].Cells[0].Selected = true;
                    }
                    else
                    {
                        MessageBox.Show(Resources.End, "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                Wait(2000);
                BtnTranslate.Enabled = true;
                BtnTranslate.UseWaitCursor = false;
                Timer1.Enabled = true;

            }
        }
        public string Extract(GeckoWebBrowser wb, string xpath, string type)
        {
            try
            {
                string result = string.Empty;
                GeckoHtmlElement Elm;
                if (TextBoxLink.Text != "")
                {
                    if (TextBoxXpathreceiver.Text != "")
                    {
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
                    }
                }
                return result;
            }
            catch
            {
                return null;
            }
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
        //private string GetHtmlFromGeckoDocument(GeckoDocument doc)
        //{
        //    var result = string.Empty;
        //    GeckoHtmlElement element;
        //    var geckoDomElement = doc.DocumentElement;
        //    if (geckoDomElement is GeckoHtmlElement)
        //    {
        //        element = (GeckoHtmlElement)geckoDomElement;
        //        result = element.InnerHtml;
        //    }
        //    return result;
        //}
        public void Fill(string value)
        {
            string str = System.Uri.EscapeDataString(Tagextract(value));
            Wb1.Navigate(Properties.Settings.Default.Link[Properties.Settings.Default.index].ToString() + str);
        }
        public void Wait(int milliseconds)
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
        private void Timer1_Tick(object sender, EventArgs e)
        {
            textescible = Extract(Wb1, Properties.Settings.Default.Xpathreceiver[Properties.Settings.Default.index], "text");
            if (BtnTranslate.Enabled == true)
            {
                if (textescible == string.Empty || textescible == textescibleold)
                {
                    BtnTranslate.Enabled = false;
                }
            }
            else
            {
                textescible = textescibleold;
                BtnTranslate.Enabled = true;
                Timer1.Enabled = false;
            }
        }
        private void Translator_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            QuitProgramm();
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.index != -1)
            {
                if (Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index] != string.Empty)
                {
                    try
                    {
                        if (Etatauto == "activate")
                        {
                            currentRow = DataGridView.SelectedRows[0].Index;
                            Fill(DataGridView.Rows[currentRow].Cells[0].Value.ToString());
                        }
                    }
                    catch { }
                }
            }
        }
        private void GeckoWebBrowser_DocumentCompleted(object sender, GeckoDocumentCompletedEventArgs e)
        {
            if (Properties.Settings.Default.index != -1)
            {
                if (Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index] != string.Empty)
                {
                    Wait(1000);
                    if (DataGridView.Rows.Count != 0)
                    {
                        Fill(DataGridView.CurrentCell.Value.ToString());
                    }
                }
            }
        }
        private string Tagextract(string text)
        {
            int a = 0;
            foreach (string item in Properties.Settings.Default.CharacterTag)
            {
                if (text.Contains(item))
                {
                    text = text.Replace(item, Properties.Settings.Default.CharacterName[a]);
                }
                a += 1;
            }
            Regex regex = new Regex(@"\{.*?\}");
            foreach (string item in Properties.Settings.Default.ListTag)
            {
                if (text.Contains(item))
                {
                    text = text.Replace(item, string.Empty);
                }
            }
            foreach (Match match in regex.Matches(text))
            {
                if (Properties.Settings.Default.ListTag.Contains(match.ToString()))
                {
                    text = text.Replace(match.ToString(), string.Empty);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show(Resources.Doyouwanttoadd + match.ToString() + Resources.tothelistoftags, "", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        DataGridViewGridListTag.Rows.Add(match.ToString());
                        SaveProperyDatagridviewListTag();
                        text = text.Replace(match.ToString(), string.Empty);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        break;
                    }
                }
            }
            return text;
        }
        ////////////////////////////////////////////////config//////////////////////////////////////////////////////////////////////////////////
        ///
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void InitializeComboBox()
        {
            if (Properties.Settings.Default.index != -1)
            {
                if (Properties.Settings.Default.Name_Translator.Count >= 1)
                {
                    ComboBoxNav.DataSource = Properties.Settings.Default.Name_Translator.Cast<string>().ToArray();
                    ComboBoxNav.SelectedIndex = Properties.Settings.Default.index;
                    TextBoxLink.Text = Properties.Settings.Default.Link[Properties.Settings.Default.index];
                    TextBoxXpathreceiver.Text = Properties.Settings.Default.Xpathreceiver[Properties.Settings.Default.index];
                }
                else
                {
                    ComboBoxNav.DataSource = null;
                    TextBoxLink.Text = string.Empty;
                    TextBoxXpathreceiver.Text = string.Empty;
                }
            }
        }
        private void BtnLinkSet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Link[Properties.Settings.Default.index] = TextBoxLink.Text;
        }
        private void BtnAddTranslator_Click(object sender, EventArgs e)
        {
            string result = Interaction.InputBox("Enter Name of translator");
            if (result != null)
            {
                Properties.Settings.Default.Name_Translator.Add(result.ToString());
                Properties.Settings.Default.Link.Add(String.Empty);
                Properties.Settings.Default.Xpathreceiver.Add(String.Empty);
                Properties.Settings.Default.index = Properties.Settings.Default.index + 1;
                Properties.Settings.Default.Save();
                InitializeComboBox();
            }
        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.index != -1)
            {
                Properties.Settings.Default.Link.RemoveAt(ComboBoxNav.SelectedIndex);
                Properties.Settings.Default.Xpathreceiver.RemoveAt(ComboBoxNav.SelectedIndex);
                Properties.Settings.Default.Name_Translator.RemoveAt(ComboBoxNav.SelectedIndex);
                Properties.Settings.Default.Save();
                TextBoxLink.Text = string.Empty;
                TextBoxXpathreceiver.Text = string.Empty;
                InitializeComboBox();
            }
        }
        private void BtnLinkSet_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.Link[ComboBoxNav.SelectedIndex] = TextBoxLink.Text;
            Properties.Settings.Default.Save();
        }
        private void BtnXpathRSet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Xpathreceiver[ComboBoxNav.SelectedIndex] = TextBoxXpathreceiver.Text;
            Properties.Settings.Default.Save();
        }
        private void TextBoxLink_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)");
            Match match = regex.Match(TextBoxLink.Text);
            if (match.Success)
            {
                TextBoxLink.BackColor = Color.White;
                BtnLinkSet.Enabled = true;
            }
            else
            {
                TextBoxLink.BackColor = Color.Red;
                BtnLinkSet.Enabled = false;
            }
        }
        private void TextBoxXpathreceiver_TextChanged(object sender, EventArgs e)
        {
            if (ValidateXpath(TextBoxXpathreceiver.Text))
            {
                TextBoxXpathreceiver.BackColor = Color.White;
                BtnXpathRSet.Enabled = true;
            }
            else
            {
                TextBoxXpathreceiver.BackColor = Color.Red;
                BtnXpathRSet.Enabled = false;
            }
        }
        public bool ValidateXpath(string xpath)
        {
            try
            {
                XPathExpression.Compile(xpath);
                return true;
            }
            catch (XPathException)
            {
                return false;
            }
        }
        private void Translator_config_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TextBoxLink.BackColor == Color.Red || TextBoxXpathreceiver.BackColor == Color.Red)
            {
                e.Cancel = true;
                MessageBox.Show(Resources.Fillconfigorrestoredefault, "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Wb1.Navigate(Properties.Settings.Default.Link[Properties.Settings.Default.index].ToString());
            }
        }
        private void BtnDefault_Click(object sender, EventArgs e)
        {
            //efface les Properties.Settings.Default
            Properties.Settings.Default.Xpathreceiver.Clear();
            Properties.Settings.Default.Link.Clear();
            Properties.Settings.Default.Name_Translator.Clear();
            //ajoute les Properties.Settings.Default deepl
            Properties.Settings.Default.Xpathreceiver.Add("/html[1]/body[1]/div[2]/div[1]/div[1]/div[4]/div[3]/div[1]/textarea[1]");
            Properties.Settings.Default.Name_Translator.Add("Deepl");
            Properties.Settings.Default.Link.Add("https://www.deepl.com/translator#fr/en/");
            //ajoute les Properties.Settings.Default Google
            Properties.Settings.Default.Xpathreceiver.Add("/html[1]/body[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/div[1]/div[2]/div[1]");
            Properties.Settings.Default.Name_Translator.Add("Google");
            Properties.Settings.Default.Link.Add("https://translate.google.com/#view=home&op=translate&sl=en&tl=fr&text=");
            Properties.Settings.Default.Save();
            InitializeComboBox();
        }
        private void ComboBoxNav_SelectedIndexChanged(object sender, EventArgs e)
        {
            //actualise les box suivant l'index
            if (Properties.Settings.Default.index != -1)
            {
                TextBoxLink.Text = Properties.Settings.Default.Link[ComboBoxNav.SelectedIndex];
                TextBoxXpathreceiver.Text = Properties.Settings.Default.Xpathreceiver[ComboBoxNav.SelectedIndex];
            }
            else
            {
                TextBoxLink.Text = string.Empty;
                TextBoxXpathreceiver.Text = string.Empty;
            }
        }
        private void InitializedataGridViewTagName()
        {
            int i = 0;
            foreach (string item in Properties.Settings.Default.CharacterTag)
            {
                DataGridViewTagName.Rows.Add(item, Properties.Settings.Default.CharacterName[i].ToString());
                i += 1;
            }
            foreach (string item in Properties.Settings.Default.ListTag)
            {
                DataGridViewGridListTag.Rows.Add(item);
            }
        }
        //private void SaveProperyDatagridviewCharcter()
        //{
        //    Properties.Settings.Default.CharacterName.Clear();
        //    Properties.Settings.Default.CharacterTag.Clear();
        //    foreach (DataGridViewRow row in DataGridViewTagName.Rows)
        //    {
        //        if (!row.IsNewRow)
        //        {
        //            string CharacterTag;
        //            string CharacterName;
        //            if (row.Cells[0].Value == null)
        //            {
        //                CharacterTag = "";
        //            }
        //            else
        //            {
        //                CharacterTag = row.Cells[0].Value.ToString();
        //            }
        //            if (row.Cells[1].Value == null)
        //            {
        //                CharacterName = "";
        //            }
        //            else
        //            {
        //                CharacterName = row.Cells[1].Value.ToString();
        //            }
        //            Properties.Settings.Default.CharacterName.Add(CharacterName);
        //            Properties.Settings.Default.CharacterTag.Add(CharacterTag);
        //        }
        //    }
        //    Properties.Settings.Default.Save();
        //}
        private void DataGridViewGridListTag_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) { SaveProperyDatagridviewListTag(); }
        private void DataGridViewGridListTag_CellEndEdit(object sender, DataGridViewCellEventArgs e) { SaveProperyDatagridviewListTag(); }
        private void SaveProperyDatagridviewListTag()
        {
            Properties.Settings.Default.ListTag.Clear();
            foreach (DataGridViewRow row in DataGridViewGridListTag.Rows)
            {
                if (!row.IsNewRow)
                {
                    string Tag = row.Cells[0].Value.ToString();
                    Properties.Settings.Default.ListTag.Add(Tag);
                }
            }
            Properties.Settings.Default.Save();
        }
        private void Cut_Click(object sender, EventArgs e)
        {
            TextBoxTarget.Cut();
        }
        private void Copy_Click(object sender, EventArgs e)
        {
            TextBoxTarget.Copy();
        }
        private void Past_Click(object sender, EventArgs e)
        {
            TextBoxTarget.Paste();
        }
        private void Insert_Item_Click(object sender, EventArgs e)
        {
            ToolStripItem item2 = sender as ToolStripItem;
            int start = TextBoxTarget.SelectionStart;
            TextBoxTarget.Text = TextBoxTarget.Text.Insert(TextBoxTarget.SelectionStart, item2.Text);
            TextBoxTarget.Select(start, 0);
            int count = new Regex(Regex.Escape(item2.Text)).Matches(DataGridView.CurrentRow.Cells[0].Value.ToString()).Count;
            int count2 = new Regex(Regex.Escape(item2.Text)).Matches(TextBoxTarget.Text).Count;
            if (count == count2)
            {
                ContextMenuStripTag.Items.Remove(item2);
                DataGridView.CurrentRow.Cells[1].Style.BackColor = Color.Empty;
            }
        }
        private void Translator_MaximumSizeChanged(object sender, EventArgs e)
        {
            DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Timerrefreshtextbox_Tick(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow != null)
            {
                if (TextBoxTarget.Focused == false)
                {
                    TextBoxTarget.Text = DataGridView.CurrentRow.Cells[1].Value.ToString();
                    TextBoxSource.Text = DataGridView.CurrentRow.Cells[0].Value.ToString();
                    TextBoxResult.Text = DataGridView.CurrentRow.Cells[2].Value.ToString();
                    RefreshContextmenu();
                }
            }
        }
        private void RefreshContextmenu()
        {
            ContextMenuStripTag.Items.Clear();
            ToolStripItem cut = ContextMenuStripTag.Items.Add("cut");
            cut.Click += Cut_Click;
            ToolStripItem copy = ContextMenuStripTag.Items.Add("copy");
            copy.Click += Copy_Click;
            ToolStripItem past = ContextMenuStripTag.Items.Add("past");
            past.Click += Past_Click;
            foreach (string item in Properties.Settings.Default.ListTag)
            {
                if (DataGridView.CurrentRow.Cells[0].Value.ToString().Contains(item))
                {
                    int count = new Regex(Regex.Escape(item)).Matches(DataGridView.CurrentRow.Cells[0].Value.ToString()).Count;
                    int count2 = new Regex(Regex.Escape(item)).Matches(DataGridView.CurrentRow.Cells[1].Value.ToString()).Count;
                    if (count != count2)
                    {
                        DataGridView.CurrentRow.Cells[1].Style.BackColor = Color.DarkBlue;
                        ToolStripItem item2 = ContextMenuStripTag.Items.Add(item);
                        item2.Click += Insert_Item_Click;
                    }
                }
            }
        }
        private void TextBoxTarget_Enter(object sender, EventArgs e)
        {
            Timerrefreshtextbox.Enabled = false;
        }
        private void TextBoxTarget_Leave(object sender, EventArgs e)
        {
            Timerrefreshtextbox.Enabled = true;
        }
        private void TextBoxTarget_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxTarget.Text.Length > 200)
            {
                TextBoxTarget.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                TextBoxTarget.ScrollBars = ScrollBars.None;
            }
            if (DataGridView.Rows.Count != 0)
            {
                if (Timerrefreshtextbox.Enabled == false)
                {
                    DataGridView.CurrentRow.Cells[1].Value = TextBoxTarget.Text;
                    RefreshContextmenu();
                    if (TextBoxTarget.Text.Length >= 1)
                    {
                        RefreshCellResult();
                    }
                }
            }
            if (DataGridView.CurrentRow.DefaultCellStyle.BackColor == Color.Yellow)
            {
                Doublon(DataGridView.CurrentRow);
            }
        }
        private void ContextMenuStripTag_Opened(object sender, EventArgs e)
        {
            Timerrefreshtextbox.Enabled = false;
        }
        private void RefreshCellResult()
        {
            string contents = DataGridView.CurrentRow.Cells[2].Value.ToString();
            Match match = MatchRenpy(contents);
            if (match.Success)
            {
                DataGridView.CurrentRow.Cells[2].Value = match.Groups["result"].Value + DataGridView.CurrentRow.Cells[1].Value + match.Groups["result2"].Value;
            }
        }
        private void OuvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = OpenFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {

                DataGridView.Rows.Clear();
                Path = OpenFileDialog1.FileName;
                string contents;
                using (StreamReader reader = new StreamReader(Path))
                {
                    contents = reader.ReadToEnd();
                    Match match = MatchRenpy(contents);
                    while (match.Success)
                    {

                        DataGridView.Rows.Add(match.Groups["text"].Value, match.Groups["text2"].Value, match.Value);
                        match = match.NextMatch();
                    }
                }
                StatutSave = false;
            }
        }
        private void EnregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Path != "")
            {
                using (StreamWriter sw = new StreamWriter(Path))
                {
                    foreach (DataGridViewRow row in DataGridView.Rows)
                    {
                        sw.Write(row.Cells[2].Value);
                    }
                    StatutSave = true;
                }
            }
        }
        private void OptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PanelConfig_Translator.Visible == false)
            {
                Panelleft.Visible = false;
                CheckBoxAuto.Visible = false;
                PanelConfig_Translator.Visible = true;
                BtnTranslate.Visible = false;
                Paneltraducteur.Visible = false;
                Timer1.Enabled = false;
            }
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (TextBoxLink.BackColor == Color.Red || TextBoxXpathreceiver.BackColor == Color.Red)
            {
                MessageBox.Show(Resources.Fillconfigorrestoredefault, "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Properties.Settings.Default.index = ComboBoxNav.SelectedIndex;
                Properties.Settings.Default.Save();
                Panelleft.Visible = true;
                CheckBoxAuto.Visible = true;
                Wb1.Navigate(Properties.Settings.Default.Link[Properties.Settings.Default.index].ToString());
                PanelConfig_Translator.Visible = false;
                BtnTranslate.Visible = true;
                Paneltraducteur.Visible = true;
                Timer1.Enabled = true;
            }
        }
        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.GeckoWebBrowser.Visible == true)
            {
                this.GeckoWebBrowser.Visible = false;
                this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
                DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                ToolStripMenuItem1.Text = "↓";
            }
            else
            {
                this.GeckoWebBrowser.Visible = true;
                this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
                DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                ToolStripMenuItem1.Text = "↑";
            }
        }
        private void QuitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuitProgramm();
        }
        private void EnregistrersousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In development");
        }
        private void PersonnaliserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DejaDoublon();
        }
        private void RechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In development");
        }
        private void AproposdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In development");
        }
        private void QuitProgramm()
        {
            if (StatutSave == false)
            {
                const string message =
                  "Le travail n'a pas était sauvegardé êtes vous sûr de vouloir quitter ?";
                const string caption = "Form Closing";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Timer1.Enabled = false;
                    Environment.Exit(0);
                }
            }
            else
            {
                Timer1.Enabled = false;
                Environment.Exit(0);
            }
        }
        private Match MatchRenpy(string contents)
        {
            Match match = Regex.Match(contents, "(?<result>(?<debut>(# TODO: Translation updated.+\\d+\\s*\\n)?(translate.+strings:\\s+)?(# game.+\\d+\\s*\\n)?(translate.+:\\s*\\n)?\\s*(#)?\\s*)(?<character>[^\\s]+)?\\s+\"(?<text>(?(?<=\\\\).|[^\"])+)\"([^\\n]+(?<fin>(?(?<=\\\\).|[^\"\\n])+))?\\s*\\n\\s*(?<character2>[^\\s]+)?\\s+\")(?<text2>(?(?<=\\\\).|[^\"])+)(?<result2>\"([^\\n]+(?<fin2>(?(?<=\\\\).|[^\"\\n])+))?(\\s*)?(\\n)?)", RegexOptions.Multiline);
            return match;
        }
        private void CheckBoxAuto_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxAuto_Verif();
        }
        private void CheckBoxAuto_Verif()
        {
            if (CheckBoxAuto.Checked == true)
            {
                CheckBoxAuto.Text = Resources.Auto_activate;
                Etatauto = "activate";
                if (DataGridView.Rows.Count != 0)
                {
                    Fill(DataGridView.CurrentRow.Cells[0].Value.ToString());
                    Wait(2000);
                }
            }
            else
            {
                CheckBoxAuto.Text = Resources.Auto_desactivate;
                Etatauto = "desactivate";
            }
        }
        private void RadioButtonBasic_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonBasic.Checked == true)
            {
                PanelAdvenced.Visible = false;
            }
            else
            {
                PanelAdvenced.Visible = true;
            }
        }
        private void BtnNEXT_Click(object sender, EventArgs e)
        {
            if (DataGridView.Rows.Count != 0)
            {
                string searchValue = TextBoxsearch.Text;
                int rowIndex = DataGridView.SelectedRows[0].Index + 1;
                int Column = 1;
                if(RadioButtonSearch1.Checked==true)
                {
                    Column = 0;
                }
                DataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    for (int t = 0; t < 2; t++)
                    {
                        bool valueResulet = false;
                        for (int i = rowIndex; i < DataGridView.Rows.Count; i++)
                        {
                            if (DataGridView.Rows[i].Cells[Column].Value.ToString().Contains(searchValue))
                            {
                                CheckBoxAuto.Checked = false;
                                DataGridView.Rows[i].Selected = true;
                                DataGridView.FirstDisplayedScrollingRowIndex = i;
                                valueResulet = true;
                                break;
                            }
                        }
                        if (valueResulet == false)
                        {
                            if (rowIndex != 0)
                            {
                                DialogResult dialogResult = MessageBox.Show(searchValue + Resources.wasnotfound, "", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    rowIndex = 0;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                MessageBox.Show(searchValue + Resources.wasnotfound2);
                                break;
                            }
                        }
                        else
                        {
                            t = 2;
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }
        private void BtnDirectoryPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog1.SelectedPath = TxtDirectoryPath.Text;
            DialogResult drResult = FolderBrowserDialog1.ShowDialog();
            if (drResult == System.Windows.Forms.DialogResult.OK)
                TxtDirectoryPath.Text = FolderBrowserDialog1.SelectedPath;
            try
            {
                ProgressBar1.Value = 0;
                // Clear All Nodes if Already Exists  
                TreeView1.Nodes.Clear();
                ToolTip1.ShowAlways = true;
                if (TxtDirectoryPath.Text != "" && Directory.Exists(TxtDirectoryPath.Text))
                    LoadDirectory(TxtDirectoryPath.Text);
                else
                    MessageBox.Show(Resources.SelectDirectory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnLoadDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                ProgressBar1.Value = 0;
                // Clear All Nodes if Already Exists  
                TreeView1.Nodes.Clear();
                ToolTip1.ShowAlways = true;
                if (TxtDirectoryPath.Text != "" && Directory.Exists(TxtDirectoryPath.Text))
                    LoadDirectory(TxtDirectoryPath.Text);
                else
                    MessageBox.Show(Resources.SelectDirectory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void LoadDirectory(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            //Setting ProgressBar Maximum Value  
            ProgressBar1.Maximum = Directory.GetFiles(Dir, "*.*", SearchOption.AllDirectories).Length + Directory.GetDirectories(Dir, "**", SearchOption.AllDirectories).Length;
            TreeNode tds = TreeView1.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            LoadFiles(Dir, tds);
            LoadSubDirectories(Dir, tds);
        }
        private void LoadSubDirectories(string dir, TreeNode td)
        {
            // Get all subdirectories  
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories  
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;
                LoadFiles(subdirectory, tds);
                LoadSubDirectories(subdirectory, tds);
                UpdateProgress();
            }
        }
        private void LoadFiles(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");

            // Loop through them to see files  
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                TreeNode tds = td.Nodes.Add(fi.Name);
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;
                UpdateProgress();
            }
        }
        private void UpdateProgress()
        {
            if (ProgressBar1.Value < ProgressBar1.Maximum)
            {
                ProgressBar1.Value++;
                int percent = (int)(((double)ProgressBar1.Value / (double)ProgressBar1.Maximum) * 100);
                ProgressBar1.CreateGraphics().DrawString(percent.ToString() + "%", new Font("Arial", (float)8.25, FontStyle.Regular), Brushes.Black, new PointF(ProgressBar1.Width / 2 - 10, ProgressBar1.Height / 2 - 7));

                Application.DoEvents();
            }
        }

        private void TreeView1_MouseMove(object sender, MouseEventArgs e)
        {
            // Get the node at the current mouse pointer location.  
            TreeNode theNode = this.TreeView1.GetNodeAt(e.X, e.Y);

            // Set a ToolTip only if the mouse pointer is actually paused on a node.  
            if (theNode != null && theNode.Tag != null)
            {
                // Change the ToolTip only if the pointer moved to a new node.  
                if (theNode.Tag.ToString() != this.ToolTip1.GetToolTip(this.TreeView1))
                    this.ToolTip1.SetToolTip(this.TreeView1, theNode.Tag.ToString());

            }
            else     // Pointer is not over a node so clear the ToolTip.  
            {
                this.ToolTip1.SetToolTip(this.TreeView1, "");
            }
        }
        private void Btnopenslide_Click(object sender, EventArgs e)
        {
            if (Panelleft.Width == 300)
            {
                TextBoxsearch.Visible = false;
                BtnNEXT.Visible = false;
                Panelleft.Width = 40;
                Paneltraducteur.Width += 260;
                Paneltraducteur.Location = new Point(40, 27);

            }
            else
            {
                TextBoxsearch.Visible = true;
                BtnNEXT.Visible = true;
                Panelleft.Width = 300;
                Paneltraducteur.Width -= 260;
                Paneltraducteur.Location = new Point(300, 27);
            }
        }
        private void Doublon(DataGridViewRow rowtocompare)
        {
            string text = rowtocompare.Cells[1].Value.ToString();
            int compteur = 0;
            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                if (rowtocompare.Cells[0].Value.ToString() == row.Cells[0].Value.ToString()) { compteur++; }
            }
            if (compteur >= 2)
            {
                foreach (DataGridViewRow row in DataGridView.Rows)
                {
                    if (rowtocompare.Cells[0].Value.ToString() == row.Cells[0].Value.ToString())
                    {
                        row.Cells[1].Value = text;
                        DataGridView.Rows[row.Index].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
        }
        private void Dejatraduit()
        {
            int compteur = 0;
            foreach (DataGridViewRow row in DataGridView.Rows)
            {
                if (row.Cells[0].Value.ToString() != row.Cells[1].Value.ToString())
                {
                    compteur = row.Index;

                }
            }
            DataGridView.Rows[compteur + 1].Selected = true;
            DataGridView.FirstDisplayedScrollingRowIndex = compteur;
            //foreach (DataGridViewRow row in DataGridView.Rows)
            //{
            //    if (compteur + 1 > row.Index)
            //        row.DefaultCellStyle.BackColor = Color.DarkGreen;
            //}
        }
        private void DejaDoublon()
        {

            foreach (DataGridViewRow row in DataGridView.Rows)
            {

                for (int i = 0; i < DataGridView.Rows.Count; i++)
                { 
                    if (row.Index != DataGridView.Rows[i].Index)
                    {
                        if (row.Cells[0].Value.ToString() == DataGridView.Rows[i].Cells[0].Value.ToString())
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                        }
                    }
                }
            }
            MessageBox.Show("fini");
        }

        private void BtnfindLast_Click(object sender, EventArgs e)
        {
            Dejatraduit();
        }
    }
}