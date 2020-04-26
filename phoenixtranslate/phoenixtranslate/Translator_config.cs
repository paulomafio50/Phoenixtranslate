using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.XPath;
using System.Drawing;
namespace phoenixtranslate
{
    public partial class Translator_config : Form
    {
        private Translator _Translator;
        public Translator_config(Translator translator)
        {
            InitializeComponent();
            this._Translator = translator;
            InitializeComboBox();
        }
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
                    comboBoxLangSource.SelectedIndex = Int32.Parse(Properties.Settings.Default.LangSource_index[comboBoxNav.SelectedIndex]);
                    comboBoxLangTarget.SelectedIndex = Int32.Parse(Properties.Settings.Default.LangTarget_index[comboBoxNav.SelectedIndex]);
                }
                else
                {
                    comboBoxNav.DataSource = null;
                    textBoxLink.Text = string.Empty;
                    textBoxXpathreceiver.Text = string.Empty;
                    comboBoxLangTarget.SelectedIndex = -1;
                    comboBoxLangSource.SelectedIndex = -1;
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
                Properties.Settings.Default.LangSource_index.Add("0");
                Properties.Settings.Default.LangTarget_index.Add("0");
                Properties.Settings.Default.Xpathreceiver.Add(String.Empty);
                Properties.Settings.Default.index = Properties.Settings.Default.index + 1;
                Properties.Settings.Default.Save();
                InitializeComboBox();
            }
        }
        private void Translator_config_Load(object sender, EventArgs e)
        {
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
                this._Translator.wb1.Navigate(Properties.Settings.Default.Link[Properties.Settings.Default.index].ToString());
            }
        }
        private void buttonDefault_Click(object sender, EventArgs e)
        {
            //efface les Properties.Settings.Default
            Properties.Settings.Default.Xpathreceiver.Clear();
            Properties.Settings.Default.Link.Clear();
            Properties.Settings.Default.Name_Translator.Clear();
            Properties.Settings.Default.LangSource_index.Clear();
            Properties.Settings.Default.LangTarget_index.Clear();
            //ajoute les Properties.Settings.Default deepl
            Properties.Settings.Default.Xpathreceiver.Add("/html[1]/body[1]/div[2]/div[1]/div[1]/div[4]/div[3]/div[1]/textarea[1]");
            Properties.Settings.Default.Name_Translator.Add("Deepl");
            Properties.Settings.Default.LangSource_index.Add("3");
            Properties.Settings.Default.LangTarget_index.Add("4");
            Properties.Settings.Default.Link.Add("https://www.deepl.com");
            //ajoute les Properties.Settings.Default Google
            Properties.Settings.Default.Xpathreceiver.Add("/html[1]/body[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/div[1]/div[2]/div[1]");
            Properties.Settings.Default.Name_Translator.Add("Google");
            Properties.Settings.Default.LangSource_index.Add("3");
            Properties.Settings.Default.LangTarget_index.Add("4");
            Properties.Settings.Default.Link.Add("https://translate.google.com/");
            //ajoute les Properties.Settings.Default Google
            Properties.Settings.Default.Xpathreceiver.Add("/html[1]/body[1]/div[2]/div[2]/div[2]/div[2]/div[1]/pre[1]");
            Properties.Settings.Default.Name_Translator.Add("Yandex");
            Properties.Settings.Default.LangSource_index.Add("3");
            Properties.Settings.Default.LangTarget_index.Add("4");
            Properties.Settings.Default.Link.Add("https://translate.yandex.com/");
            Properties.Settings.Default.index = 2;
            Properties.Settings.Default.Save();
            InitializeComboBox();
        }
        private void comboBoxNav_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.index = comboBoxNav.SelectedIndex;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.index != -1)
            {
                textBoxLink.Text = Properties.Settings.Default.Link[comboBoxNav.SelectedIndex];
                textBoxXpathreceiver.Text = Properties.Settings.Default.Xpathreceiver[comboBoxNav.SelectedIndex];
                comboBoxLangSource.SelectedIndex = Int32.Parse(Properties.Settings.Default.LangSource_index[comboBoxNav.SelectedIndex]);
                comboBoxLangTarget.SelectedIndex = Int32.Parse(Properties.Settings.Default.LangTarget_index[comboBoxNav.SelectedIndex]);
            }
            else
            {
                textBoxLink.Text = string.Empty;
                textBoxXpathreceiver.Text = string.Empty;
            }
        }
        private void comboBoxNav_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void comboBoxLangSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LangSource_index[Properties.Settings.Default.index] = comboBoxLangSource.SelectedIndex.ToString();
        }

        private void comboBoxLangTarget_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.LangTarget_index[Properties.Settings.Default.index] = comboBoxLangTarget.SelectedIndex.ToString();
        }
    }
}
