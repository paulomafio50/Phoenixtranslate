using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Gecko;
using Gecko.DOM;
using System.Text.RegularExpressions;
using Gecko.Events;
using Microsoft.VisualBasic;
using System.Xml.XPath;
using System.IO;
using System.Media;
namespace phoenixtranslate
{
    public partial class Translator : Form
    {
        Form import = new Import();
        //remetre droit ctrl+K et D
        public Boolean StatutSave = true;
        public string Path = "";
        public int currentRow;
        public string ActivateTraslate = string.Empty;
        public string textesource;
        public string textescible = "";
        public string textescibleold = "old";
        public string Etatauto = "activate";
        public GeckoWebBrowser Wb1 => geckoWebBrowser1;
        public Translator()
        {
            InitializeComponent();
            Gecko.Xpcom.Initialize("Firefox");
            InitializeComboBox();
            InitializedataGridViewTagName();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Name_Translator.Cast<string>().ToArray().Length == 0)
            {
                Properties.Settings.Default.index = -1;
                Properties.Settings.Default.Save();
            }
            else
            {
                int a = Properties.Settings.Default.index;
                geckoWebBrowser1.Navigate(Properties.Settings.Default.Link[Properties.Settings.Default.index].ToString());
            }
            tabControltextbox.SelectedTab = tabTarget;
            checkBoxAuto.Checked = true;
        }
        protected override void OnClosed(EventArgs e)
        {
            geckoWebBrowser1.Dispose();
            Xpcom.Shutdown();
            base.OnClosed(e);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            buttonTranslate.Enabled = false;
            buttonTranslate.UseWaitCursor = true;

            if (checkBoxAuto.Checked==false)
            {
                checkBoxAuto.Checked = true;
                currentRow = dataGridView1.SelectedRows[0].Index;
                fill(Wb1, (Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index]), (Properties.Settings.Default.Querysender[Properties.Settings.Default.index]), dataGridView1.Rows[currentRow].Cells[0].Value.ToString());
                wait(2000);
            }
            checkBoxAuto.Checked = true;
            if (Properties.Settings.Default.index != -1)
            {
                string texttranslated = Extract(Wb1, Properties.Settings.Default.Xpathreceiver[Properties.Settings.Default.index], "text");
               
                if (texttranslated == null)
                {
                    MessageBox.Show("incorrect config");
                    timer1.Enabled = false;
                }
                else
                {
                    if (texttranslated.Contains(@""""))
                    {
                        texttranslated = texttranslated.Replace(@"""", @"");
                       MessageBox.Show("Attention les guillemets ont été enlevés");
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
                        if (dataGridView1.CurrentRow.Cells[0].Value.ToString().StartsWith(item))
                        {
                            texttranslated = texttranslated.Insert(0, item);
                        }
                        if (dataGridView1.CurrentRow.Cells[0].Value.ToString().EndsWith(item))
                        {
                            texttranslated = texttranslated.Insert(texttranslated.Length, item);
                        }
                    }
                    dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value = texttranslated;
                    RefreshCellResult();
                    foreach (string item in Properties.Settings.Default.ListTag)
                    {
                        if (dataGridView1.CurrentRow.Cells[0].Value.ToString().Contains(item))
                        {
                            int count = new Regex(Regex.Escape(item)).Matches(dataGridView1.CurrentRow.Cells[0].Value.ToString()).Count;
                            int count2 = new Regex(Regex.Escape(item)).Matches(dataGridView1.CurrentRow.Cells[1].Value.ToString()).Count;
                            if (count != count2)
                            {
                                dataGridView1.CurrentRow.Cells[1].Style.BackColor = Color.DarkBlue;
                            }
                        }
                    }
                    if (dataGridView1.SelectedRows[0].Index < dataGridView1.RowCount - 1)
                    {
                        dataGridView1.Rows[++currentRow].Cells[0].Selected = true;
                    }
                    else
                    {
                        MessageBox.Show("Fin.", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                wait(2000);
                buttonTranslate.Enabled = true;
                buttonTranslate.UseWaitCursor = false;
                timer1.Enabled = true;
             
            }
        }
        public string Extract(GeckoWebBrowser wb, string xpath, string type)
        {
            try
            {
                string result = string.Empty;
                GeckoHtmlElement Elm;
                if (textBoxLink.Text != "")
                {
                    if (textBoxXpathreceiver.Text != "")
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
            string str = System.Uri.EscapeDataString(Tagextract(value));
            Wb1.Navigate(Properties.Settings.Default.Link[Properties.Settings.Default.index].ToString() + str);
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            textescible = Extract(Wb1, Properties.Settings.Default.Xpathreceiver[Properties.Settings.Default.index], "text");
            if (buttonTranslate.Enabled == true)
            {
                if (textescible == string.Empty || textescible == textescibleold)
                {
                    buttonTranslate.Enabled = false;
                }
            }
            else
            {
                textescible = textescibleold;
                buttonTranslate.Enabled = true;
                timer1.Enabled = false;
            }
        }
        private void Translator_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            QuitProgramm();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.index != -1)
            {
                if (Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index] != string.Empty)
                {
                    try
                    {
                        if (Etatauto == "activate")
                        {
                            currentRow = dataGridView1.SelectedRows[0].Index;
                            fill(Wb1, (Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index]), (Properties.Settings.Default.Querysender[Properties.Settings.Default.index]), dataGridView1.Rows[currentRow].Cells[0].Value.ToString());
                        }
                    }
                    catch { }
                }
            }
        }
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
                    if (dataGridView1.Rows.Count != 0)
                    {
                        fill(Wb1, (Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index]), (Properties.Settings.Default.Querysender[Properties.Settings.Default.index]), dataGridView1.CurrentCell.Value.ToString());
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
                    DialogResult dialogResult = MessageBox.Show("Do you want to add " + match.ToString() + "to the list of tags", "Question", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dataGridViewGridListTag.Rows.Add(match.ToString());
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
                    comboBoxNav.DataSource = Properties.Settings.Default.Name_Translator.Cast<string>().ToArray();
                    comboBoxNav.SelectedIndex = Properties.Settings.Default.index;
                    textBoxLink.Text = Properties.Settings.Default.Link[Properties.Settings.Default.index];
                    textBoxXpathreceiver.Text = Properties.Settings.Default.Xpathreceiver[Properties.Settings.Default.index];
                }
                else
                {
                    comboBoxNav.DataSource = null;
                    textBoxLink.Text = string.Empty;
                    textBoxXpathreceiver.Text = string.Empty;
                }
            }
        }
        private void buttonLinkSet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Link[Properties.Settings.Default.index] = textBoxLink.Text;
        }
        private void buttonAddTranslator_Click(object sender, EventArgs e)
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
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.index != -1)
            {
                Properties.Settings.Default.Link.RemoveAt(comboBoxNav.SelectedIndex);
                Properties.Settings.Default.Xpathreceiver.RemoveAt(comboBoxNav.SelectedIndex);
                Properties.Settings.Default.Name_Translator.RemoveAt(comboBoxNav.SelectedIndex);
                Properties.Settings.Default.Save();
                textBoxLink.Text = string.Empty;
                textBoxXpathreceiver.Text = string.Empty;
                InitializeComboBox();
            }
        }
        private void buttonLinkSet_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.Link[comboBoxNav.SelectedIndex] = textBoxLink.Text;
            Properties.Settings.Default.Save();
        }
        private void buttonXpathRSet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Xpathreceiver[comboBoxNav.SelectedIndex] = textBoxXpathreceiver.Text;
            Properties.Settings.Default.Save();
        }
        private void textBoxLink_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)");
            Match match = regex.Match(textBoxLink.Text);
            if (match.Success)
            {
                textBoxLink.BackColor = Color.White;
                buttonLinkSet.Enabled = true;
            }
            else
            {
                textBoxLink.BackColor = Color.Red;
                buttonLinkSet.Enabled = false;
            }
        }
        private void textBoxXpathreceiver_TextChanged(object sender, EventArgs e)
        {
            if (ValidateXpath(textBoxXpathreceiver.Text))
            {
                textBoxXpathreceiver.BackColor = Color.White;
                buttonXpathRSet.Enabled = true;
            }
            else
            {
                textBoxXpathreceiver.BackColor = Color.Red;
                buttonXpathRSet.Enabled = false;
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
            if (textBoxLink.BackColor == Color.Red || textBoxXpathreceiver.BackColor == Color.Red)
            {
                e.Cancel = true;
                MessageBox.Show("Fill config or restore default", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Wb1.Navigate(Properties.Settings.Default.Link[Properties.Settings.Default.index].ToString());
            }
        }
        private void buttonDefault_Click(object sender, EventArgs e)
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
        private void comboBoxNav_SelectedIndexChanged(object sender, EventArgs e)
        {
            //actualise les box suivant l'index
          
            if (Properties.Settings.Default.index != -1)
            {
                textBoxLink.Text = Properties.Settings.Default.Link[comboBoxNav.SelectedIndex];
                textBoxXpathreceiver.Text = Properties.Settings.Default.Xpathreceiver[comboBoxNav.SelectedIndex];
            }
            else
            {
                textBoxLink.Text = string.Empty;
                textBoxXpathreceiver.Text = string.Empty;
            }
        }
        private void InitializedataGridViewTagName()
        {
            int i = 0;
            foreach (string item in Properties.Settings.Default.CharacterTag)
            {
                dataGridViewTagName.Rows.Add(item, Properties.Settings.Default.CharacterName[i].ToString());
                i += 1;
            }
            foreach (string item in Properties.Settings.Default.ListTag)
            {
                dataGridViewGridListTag.Rows.Add(item);
            }
        }
        private void DataGridViewTagName_CellEndEdit(object sender, DataGridViewCellEventArgs e) { SaveProperyDatagridviewCharcter(); }
        private void DataGridViewTagName_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) { SaveProperyDatagridviewCharcter(); }
        private void SaveProperyDatagridviewCharcter()
        {
            Properties.Settings.Default.CharacterName.Clear();
            Properties.Settings.Default.CharacterTag.Clear();
            foreach (DataGridViewRow row in dataGridViewTagName.Rows)
            {
                if (!row.IsNewRow)
                {
                    string CharacterTag;
                    string CharacterName;
                    if (row.Cells[0].Value == null)
                    {
                        CharacterTag = "";
                    }
                    else
                    {
                        CharacterTag = row.Cells[0].Value.ToString();
                    }
                    if (row.Cells[1].Value == null)
                    {
                        CharacterName = "";
                    }
                    else
                    {
                        CharacterName = row.Cells[1].Value.ToString();
                    }
                    Properties.Settings.Default.CharacterName.Add(CharacterName);
                    Properties.Settings.Default.CharacterTag.Add(CharacterTag);
                }
            }
            Properties.Settings.Default.Save();
        }
        private void DataGridViewGridListTag_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) { SaveProperyDatagridviewListTag(); }
        private void DataGridViewGridListTag_CellEndEdit(object sender, DataGridViewCellEventArgs e) { SaveProperyDatagridviewListTag(); }
        private void SaveProperyDatagridviewListTag()
        {
            Properties.Settings.Default.ListTag.Clear();
            foreach (DataGridViewRow row in dataGridViewGridListTag.Rows)
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
            textBox1.Cut();
        }
        private void Copy_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }
        private void Past_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
        private void Insert_Item_Click(object sender, EventArgs e)
        {
            ToolStripItem item2 = sender as ToolStripItem;
            int start = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(textBox1.SelectionStart, item2.Text);
            textBox1.Select(start, 0);
            int count = new Regex(Regex.Escape(item2.Text)).Matches(dataGridView1.CurrentRow.Cells[0].Value.ToString()).Count;
            int count2 = new Regex(Regex.Escape(item2.Text)).Matches(textBox1.Text).Count;
            if (count == count2)
            {
                contextMenuStripTag.Items.Remove(item2);
                dataGridView1.CurrentRow.Cells[1].Style.BackColor = Color.Empty;
            }
        }
        private void Translator_MaximumSizeChanged(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void timerrefreshtextbox_Tick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (textBox1.Focused == false)
                {
                    textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    RefreshContextmenu();
                }
            }
        }
        private void RefreshContextmenu()
        {
            contextMenuStripTag.Items.Clear();
            ToolStripItem cut = contextMenuStripTag.Items.Add("cut");
            cut.Click += Cut_Click;
            ToolStripItem copy = contextMenuStripTag.Items.Add("copy");
            copy.Click += Copy_Click;
            ToolStripItem past = contextMenuStripTag.Items.Add("past");
            past.Click += Past_Click;
            foreach (string item in Properties.Settings.Default.ListTag)
            {
                if (dataGridView1.CurrentRow.Cells[0].Value.ToString().Contains(item))
                {
                    int count = new Regex(Regex.Escape(item)).Matches(dataGridView1.CurrentRow.Cells[0].Value.ToString()).Count;
                    int count2 = new Regex(Regex.Escape(item)).Matches(dataGridView1.CurrentRow.Cells[1].Value.ToString()).Count;
                    if (count != count2)
                    {
                        dataGridView1.CurrentRow.Cells[1].Style.BackColor = Color.DarkBlue;
                        ToolStripItem item2 = contextMenuStripTag.Items.Add(item);
                        item2.Click += Insert_Item_Click;
                    }
                }
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            timerrefreshtextbox.Enabled = false;
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            timerrefreshtextbox.Enabled = true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (timerrefreshtextbox.Enabled == false)
            {
                dataGridView1.CurrentRow.Cells[1].Value = textBox1.Text;
                RefreshContextmenu();
                if (textBox1.Text.Length >= 1)
                {
                    RefreshCellResult();
                }
            }
        }
        private void contextMenuStripTag_Opened(object sender, EventArgs e)
        {
            timerrefreshtextbox.Enabled = false;
        }
        private void RefreshCellResult()
        {
            string contents = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Match match = MatchRenpy(contents);
            if (match.Success)
            {
                dataGridView1.CurrentRow.Cells[2].Value = match.Groups["result"].Value + dataGridView1.CurrentRow.Cells[1].Value + match.Groups["result2"].Value;
            }
        }
        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                dataGridView1.Rows.Clear();
                Path = openFileDialog1.FileName;
                string contents;
                using (StreamReader reader = new StreamReader(Path))
                {
                    contents = reader.ReadToEnd();
                    Match match = MatchRenpy(contents);
                    while (match.Success)
                    {
                        dataGridView1.Rows.Add(match.Groups["text"].Value, match.Groups["text2"].Value, match.Value);
                        match = match.NextMatch();
                    }
                }
                StatutSave = false;
            }
        }
        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Path != "")
            {
                using (StreamWriter sw = new StreamWriter(Path))
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        sw.Write(row.Cells[2].Value);
                    }
                    StatutSave = true;
                }
            }
        }
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelConfig_Translator.Visible == false)
            {
                checkBoxAuto.Visible = false;
                panelConfig_Translator.Visible = true;
                buttonTranslate.Visible = false;
                paneltraducteur.Visible = false;
                timer1.Enabled = false;
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (textBoxLink.BackColor == Color.Red || textBoxXpathreceiver.BackColor == Color.Red)
            {
                MessageBox.Show("Fill config or restore default", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                  Properties.Settings.Default.index = comboBoxNav.SelectedIndex;
            Properties.Settings.Default.Save();
                checkBoxAuto.Visible = true;
                Wb1.Navigate(Properties.Settings.Default.Link[Properties.Settings.Default.index].ToString());
                panelConfig_Translator.Visible = false;
                buttonTranslate.Visible = true;
                paneltraducteur.Visible = true;
                timer1.Enabled = true;
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.geckoWebBrowser1.Visible == true)
            {
                this.geckoWebBrowser1.Visible = false;
                this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
                dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                toolStripMenuItem1.Text = "↓";
            }
            else
            {
                this.geckoWebBrowser1.Visible = true;
                this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
                dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
                toolStripMenuItem1.Text = "↑";
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuitProgramm();
        }
        private void enregistrersousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In developpement");
        }
        private void personnaliserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In developpement");
        }
        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In developpement");
        }
        private void àproposdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In developpement");
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
                    timer1.Enabled = false;
                    Environment.Exit(0);
                }
            }
            else
            {
                timer1.Enabled = false;
                Environment.Exit(0);
            }
        }
        private Match MatchRenpy(string contents)
        {
            Match match = Regex.Match(contents, "(?<result>(?<debut>(# TODO: Translation updated.+\\d+\\s*\\n)?(translate.+strings:\\s+)?(# game.+\\d+\\s*\\n)?(translate.+:\\s*\\n)?\\s*(#)?\\s*)(?<character>[^\\s]+)?\\s+\"(?<text>(?(?<=\\\\).|[^\"])+)\"([^\\n]+(?<fin>(?(?<=\\\\).|[^\"\\n])+))?\\s*\\n\\s*(?<character2>[^\\s]+)?\\s+\")(?<text2>(?(?<=\\\\).|[^\"])+)(?<result2>\"([^\\n]+(?<fin2>(?(?<=\\\\).|[^\"\\n])+))?(\\s*)?(\\n)?)", RegexOptions.Multiline);
            return match;
        }


        private void checkBoxAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAuto.Checked == true)
            {
                checkBoxAuto.Text = "Auto activate";
                Etatauto = "activate";
            }
            else
            {
                checkBoxAuto.Text = "Auto desactivate";
                Etatauto = "desactivate";
            }
        }

        private void geckoWebBrowser1_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonBasic_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonBasic.Checked==true)
            {
                panelAdvenced.Visible = false;
            }
            else
            {
                panelAdvenced.Visible = true;
            }
        }
    }
}