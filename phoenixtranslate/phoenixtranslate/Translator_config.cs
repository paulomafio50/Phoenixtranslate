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
                    textBoxXpathsender.Text = Properties.Settings.Default.Xpathsender[Properties.Settings.Default.index];
                    textBoxQuerysender.Text = Properties.Settings.Default.Querysender[Properties.Settings.Default.index];
                    textBoxXpathreceiver.Text = Properties.Settings.Default.Xpathreceiver[Properties.Settings.Default.index];

                }
                else
                {
                    comboBoxNav.DataSource = null;
                   textBoxLink.Text = string.Empty;
                    textBoxXpathsender.Text = string.Empty;
                    textBoxQuerysender.Text = string.Empty;
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
                Properties.Settings.Default.Xpathsender.Add(String.Empty);
                Properties.Settings.Default.Querysender.Add(String.Empty);

                Properties.Settings.Default.index = Properties.Settings.Default.index +1;
                Properties.Settings.Default.Save();
                //comboBoxNav.SelectedIndex = Properties.Settings.Default.index;
                //if (Properties.Settings.Default.index == -1)
                //{
                //    Properties.Settings.Default.index = 0;
                //    Properties.Settings.Default.Save();
                //}
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
                Properties.Settings.Default.Querysender.RemoveAt(comboBoxNav.SelectedIndex);
                Properties.Settings.Default.Xpathsender.RemoveAt(comboBoxNav.SelectedIndex);
                Properties.Settings.Default.Name_Translator.RemoveAt(comboBoxNav.SelectedIndex);
                Properties.Settings.Default.Save();
                textBoxLink.Text = string.Empty;
                textBoxQuerysender.Text = string.Empty;
                textBoxXpathreceiver.Text = string.Empty;
                textBoxXpathsender.Text = string.Empty;
                
              




                InitializeComboBox();


            }

        }





        private void buttonLinkSet_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.Link[comboBoxNav.SelectedIndex] = textBoxLink.Text;
            Properties.Settings.Default.Save();

        }

        private void buttonXpathSSet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Xpathsender[comboBoxNav.SelectedIndex] = textBoxXpathsender.Text;
            Properties.Settings.Default.Save();
        }
        private void buttonQuerySet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Querysender[comboBoxNav.SelectedIndex] = textBoxQuerysender.Text;
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


        private void textBoxXpathsender_TextChanged(object sender, EventArgs e)
        {
            if (ValidateXpath(textBoxXpathsender.Text))
            {
                textBoxXpathsender.BackColor = Color.White;
                buttonXpathSSet.Enabled = true;
            }
            else
            {
                textBoxXpathsender.BackColor = Color.Red;
                buttonXpathSSet.Enabled = false;
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
        private void textBoxQuerysender_TextChanged(object sender, EventArgs e)
        {



            if (textBoxQuerysender.Text.Length > 0)
            {
                textBoxQuerysender.BackColor = Color.White;
                buttonQuerySet.Enabled = true;
            }
            else
            {
                textBoxQuerysender.BackColor = Color.Red;
                buttonQuerySet.Enabled = false;
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
            if (textBoxLink.BackColor == Color.Red || textBoxXpathreceiver.BackColor == Color.Red || textBoxXpathsender.BackColor == Color.Red)
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
            Properties.Settings.Default.Xpathsender.Clear();
            Properties.Settings.Default.Link.Clear();
            Properties.Settings.Default.Name_Translator.Clear();
            Properties.Settings.Default.Querysender.Clear();

            //ajoute les Properties.Settings.Default deepl
            Properties.Settings.Default.Xpathreceiver.Add("/html[1]/body[1]/div[2]/div[1]/div[1]/div[4]/div[3]/div[1]/textarea[1]");
            Properties.Settings.Default.Xpathsender.Add("/html[1]/body[1]/div[2]/div[1]/div[1]/div[3]/div[2]/div[1]/textarea[1]");
            Properties.Settings.Default.Querysender.Add("#dl_translator > div.lmt__sides_container > div.lmt__side_container.lmt__side_container--source > div.lmt__textarea_container > div > textarea");
            Properties.Settings.Default.Name_Translator.Add("Deepl");
            Properties.Settings.Default.Link.Add("https://www.deepl.com/translator");
            //ajoute les Properties.Settings.Default Google
            Properties.Settings.Default.Xpathreceiver.Add("/html[1]/body[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/div[1]/div[2]/div[1]");
            Properties.Settings.Default.Xpathsender.Add("/html/body/div[2]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/div/div/div[1]/textarea");
            Properties.Settings.Default.Querysender.Add("#source");
            Properties.Settings.Default.Name_Translator.Add("Google");
            Properties.Settings.Default.Link.Add("https://translate.google.com/");
            //ajoute les Properties.Settings.Default Google
            Properties.Settings.Default.Xpathreceiver.Add("/html[1]/body[1]/div[2]/div[2]/div[2]/div[2]/div[1]/pre[1]");
            Properties.Settings.Default.Xpathsender.Add("/html[1]/body[1]/div[2]/div[2]/div[1]/div[2]/div[1]/textarea[1]");
            Properties.Settings.Default.Querysender.Add("#fakeArea");
            Properties.Settings.Default.Name_Translator.Add("Yandex");
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
                textBoxXpathsender.Text = Properties.Settings.Default.Xpathsender[comboBoxNav.SelectedIndex];
                textBoxQuerysender.Text = Properties.Settings.Default.Querysender[comboBoxNav.SelectedIndex];
                textBoxXpathreceiver.Text = Properties.Settings.Default.Xpathreceiver[comboBoxNav.SelectedIndex];
            }
            else
            {
                textBoxLink.Text = string.Empty;
                textBoxXpathsender.Text = string.Empty;
                textBoxQuerysender.Text = string.Empty;
                textBoxXpathreceiver.Text = string.Empty;
            }
        }
        private void comboBoxNav_SelectionChangeCommitted(object sender, EventArgs e)
        {
       


        }

    }
}
