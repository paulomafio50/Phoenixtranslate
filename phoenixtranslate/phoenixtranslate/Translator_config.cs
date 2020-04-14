using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace phoenixtranslate
{
    public partial class Translator_config : Form
    {
        public int index;
        private Translator _Translator;
        public Translator_config(Translator translator)
        
        {
            InitializeComponent();
            this._Translator = translator;
            InitializeComboBox();
        }
        private void InitializeComboBox()
        {

            if (Properties.Settings.Default.Name_Translator.Count == 0)
            {
                Properties.Settings.Default.Name_Translator.Add("");

            }
            else
            {

            
                foreach (string s in Properties.Settings.Default.Name_Translator)
                {
                    comboBoxNav.Items.Add(s);
                }
                comboBoxNav.SelectedIndex = 0;
                index = comboBoxNav.SelectedIndex;
                textBoxLink.Text = Properties.Settings.Default.Link[index];
                comboBoxNav.SelectedIndexChanged += ComboBoxIndexChangedEventHandler;
            }

        }
        private void ComboBoxIndexChangedEventHandler(object sender,EventArgs e)
        {
            index = comboBoxNav.SelectedIndex;
            textBoxLink.Text = Properties.Settings.Default.Link[index];
            this._Translator.geckoWebBrowser.Navigate(Properties.Settings.Default.Link[index].ToString());
        }
        //private void Translator_config_Load(object sender, EventArgs e)
        //{
          
        //    comboBoxNav.SelectedIndex = Properties.Settings.Default.comboboxNavindex;
        //    switch (comboBoxNav.SelectedItem)
        //    {
        //        case "Deepl":
        //            {
        //                textBoxXpathreceive.Text = Properties.Settings.Default.XpathDeeplR;
        //                textBoxXpathsender.Text = Properties.Settings.Default.XpathDeeplS;
        //                break;
        //            }
        //        case "Google":
        //            {
        //                textBoxXpathreceive.Text = Properties.Settings.Default.XpathGoogleR;
        //                textBoxXpathsender.Text = Properties.Settings.Default.XpathGoogleS;
        //                break;
        //            }
        //        case "Yandex":
        //            {
        //                textBoxXpathreceive.Text = Properties.Settings.Default.XpathyandexR;
        //                textBoxXpathsender.Text = Properties.Settings.Default.XpathyandexS;
        //                break;
        //            }
        //    }
        //}

        //private void comboBoxNav_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Properties.Settings.Default.comboboxNavindex = comboBoxNav.SelectedIndex;
        //    Properties.Settings.Default.comboboxNav = comboBoxNav.GetItemText(comboBoxNav.SelectedItem);
        //    Properties.Settings.Default.Save();
        //    switch (comboBoxNav.SelectedItem)
        //    {
        //        case "Deepl":
        //            {
        //                textBoxXpathreceive.Text = Properties.Settings.Default.XpathDeeplR;
        //                textBoxXpathsender.Text = Properties.Settings.Default.XpathDeeplS;
        //                Properties.Settings.Default.comboboxNav = "https://www.deepl.com/translator";
        //                break;
        //            }
        //        case "Google":
        //            {
        //                textBoxXpathreceive.Text = Properties.Settings.Default.XpathGoogleR;
        //                textBoxXpathsender.Text = Properties.Settings.Default.XpathGoogleS;
        //                Properties.Settings.Default.comboboxNav = "https://translate.google.com";
        //                break;
        //            }
        //        case "Yandex":
        //            {
        //                textBoxXpathreceive.Text = Properties.Settings.Default.XpathyandexR;
        //                textBoxXpathsender.Text = Properties.Settings.Default.XpathyandexS;
        //                Properties.Settings.Default.comboboxNav = "https://translate.yandex.com/";
        //                break;
        //            }
        //    }
        //    Properties.Settings.Default.Save();
        //    this._Translator.geckoWebBrowser.Navigate(Properties.Settings.Default.comboboxNav);
        //}
        //private void buttonXpathsenderSet_Click(object sender, EventArgs e)
        //{
        //    switch (comboBoxNav.SelectedItem)
        //    {
        //        case "Deepl":
        //            {
        //                Properties.Settings.Default.XpathDeeplS = textBoxXpathsender.Text;
        //                break;
        //            }
        //        case "Google":
        //            {
        //                Properties.Settings.Default.XpathGoogleS = textBoxXpathsender.Text;
        //                break;
        //            }
        //        case "Yandex":
        //            {
        //                Properties.Settings.Default.XpathyandexS = textBoxXpathsender.Text;
        //                break;
        //            }
        //    }
        //    Properties.Settings.Default.Save();
        //}
        //private void buttonbuttonXpathrecieverSet_Click(object sender, EventArgs e)
        //{
        //    switch (comboBoxNav.SelectedItem)
        //    {
        //        case "Deepl":
        //            {
        //                Properties.Settings.Default.XpathDeeplR = textBoxXpathreceive.Text;
        //                break;
        //            }
        //        case "Google":
        //            {
        //                Properties.Settings.Default.XpathGoogleR = textBoxXpathreceive.Text;
        //                break;
        //            }
        //        case "Yandex":
        //            {
        //                Properties.Settings.Default.XpathyandexR = textBoxXpathreceive.Text;
        //                break;
        //            }
        //    }
        //    Properties.Settings.Default.Save();
        //}
        #region function Lang
        public string Lang(string Lang)
        {
            switch (Lang)
            {
                case "Afrikaans":
                    {
                        Lang = "af";
                        break;
                    }
                case "Albanian":
                    {
                        Lang = "sq";
                        break;
                    }
                case "Amharic":
                    {
                        Lang = "am";
                        break;
                    }
                case "Arabic":
                    {
                        Lang = "ar";
                        break;
                    }
                case "Armenian":
                    {
                        Lang = "hy";
                        break;
                    }
                case "Azerbaijani":
                    {
                        Lang = "az";
                        break;
                    }
                case "Basque":
                    {
                        Lang = "eu";
                        break;
                    }
                case "Belarusian":
                    {
                        Lang = "be";
                        break;
                    }
                case "Bengah":
                    {
                        Lang = "bn";
                        break;
                    }
                case "Bosnian":
                    {
                        Lang = "bs";
                        break;
                    }
                case "Bulgarian":
                    {
                        Lang = "bg";
                        break;
                    }
                case "Catalan":
                    {
                        Lang = "ca";
                        break;
                    }
                case "Cebuano":
                    {
                        Lang = "ceb";
                        break;
                    }
                case "Chichewa":
                    {
                        Lang = "ny";
                        break;
                    }
                case "Chinese":
                    {
                        Lang = "zh-CN";
                        break;
                    }
                case "Corsican":
                    {
                        Lang = "co";
                        break;
                    }
                case "Croatian":
                    {
                        Lang = "hr";
                        break;
                    }
                case "Czech":
                    {
                        Lang = "cs";
                        break;
                    }
                case "Danish":
                    {
                        Lang = "da";
                        break;
                    }
                case "Dutch":
                    {
                        Lang = "nl";
                        break;
                    }
                case "English":
                    {
                        Lang = "en";
                        break;
                    }
                case "Esperanto":
                    {
                        Lang = "eo";
                        break;
                    }
                case "Estonian":
                    {
                        Lang = "et";
                        break;
                    }
                case "Filipino":
                    {
                        Lang = "tl";
                        break;
                    }
                case "Finnish":
                    {
                        Lang = "fi";
                        break;
                    }
                case "French":
                    {
                        Lang = "fr";
                        break;
                    }
                case "Frisian":
                    {
                        Lang = "fy";
                        break;
                    }
                case "Galician":
                    {
                        Lang = "gl";
                        break;
                    }
                case "Georgian":
                    {
                        Lang = "ka";
                        break;
                    }
                case "German":
                    {
                        Lang = "de";
                        break;
                    }
                case "Greek":
                    {
                        Lang = "el";
                        break;
                    }
                case "Gujarati":
                    {
                        Lang = "gu";
                        break;
                    }
                case "Haitian Creole":
                    {
                        Lang = "ht";
                        break;
                    }
                case "Hausa":
                    {
                        Lang = "ha";
                        break;
                    }
                case "Hawaiian":
                    {
                        Lang = "haw";
                        break;
                    }
                case "Hebrew":
                    {
                        Lang = "iw";
                        break;
                    }
                case "Hindi":
                    {
                        Lang = "hi";
                        break;
                    }
                case "Hmong":
                    {
                        Lang = "hmn";
                        break;
                    }
                case "Hunganan":
                    {
                        Lang = "hu";
                        break;
                    }
                case "Icelandic":
                    {
                        Lang = "is";
                        break;
                    }
                case "lgbo":
                    {
                        Lang = "ig";
                        break;
                    }
                case "Indonesian":
                    {
                        Lang = "id";
                        break;
                    }
                case "Irish":
                    {
                        Lang = "ga";
                        break;
                    }
                case "Italian":
                    {
                        Lang = "it";
                        break;
                    }
                case "Japanese":
                    {
                        Lang = "ja";
                        break;
                    }
                case "Javanese":
                    {
                        Lang = "jw";
                        break;
                    }
                case "Kannada":
                    {
                        Lang = "kn";
                        break;
                    }
                case "Kazakh":
                    {
                        Lang = "kk";
                        break;
                    }
                case "Khmer":
                    {
                        Lang = "km";
                        break;
                    }
                case "Korean":
                    {
                        Lang = "ko";
                        break;
                    }
                case "Kurdish(Kurmanji)":
                    {
                        Lang = "ku";
                        break;
                    }
                case "Kyrgyz":
                    {
                        Lang = "ky";
                        break;
                    }
                case "Lao":
                    {
                        Lang = "lo";
                        break;
                    }
                case "Latin":
                    {
                        Lang = "la";
                        break;
                    }
                case "Latvian":
                    {
                        Lang = "lv";
                        break;
                    }
                case "Lithuanian":
                    {
                        Lang = "lt";
                        break;
                    }
                case "Luxembourgish":
                    {
                        Lang = "lb";
                        break;
                    }
                case "Macedonian":
                    {
                        Lang = "mk";
                        break;
                    }
                case "Malagasy":
                    {
                        Lang = "mg";
                        break;
                    }
                case "Malay":
                    {
                        Lang = "ms";
                        break;
                    }
                case "Malayalam":
                    {
                        Lang = "ml";
                        break;
                    }
                case "Maltese":
                    {
                        Lang = "mt";
                        break;
                    }
                case "Maori":
                    {
                        Lang = "mi";
                        break;
                    }
                case "Marathi":
                    {
                        Lang = "mr";
                        break;
                    }
                case "Mongolian":
                    {
                        Lang = "mn";
                        break;
                    }
                case "Myanmar(Burmese)":
                    {
                        Lang = "my";
                        break;
                    }
                case "Nepali":
                    {
                        Lang = "ne";
                        break;
                    }
                case "Norwegian":
                    {
                        Lang = "no";
                        break;
                    }
                case "Pashto":
                    {
                        Lang = "ps";
                        break;
                    }
                case "Persian":
                    {
                        Lang = "fa";
                        break;
                    }
                case "Polish":
                    {
                        Lang = "pl";
                        break;
                    }
                case "Portuguese":
                    {
                        Lang = "pt";
                        break;
                    }
                case "Punjabi":
                    {
                        Lang = "pa";
                        break;
                    }
                case "Romanian":
                    {
                        Lang = "ro";
                        break;
                    }
                case "Russian":
                    {
                        Lang = "ru";
                        break;
                    }
                case "Samoan":
                    {
                        Lang = "sm";
                        break;
                    }
                case "Scots Gaelic":
                    {
                        Lang = "gd";
                        break;
                    }
                case "Serbian":
                    {
                        Lang = "sr";
                        break;
                    }
                case "Sesotho":
                    {
                        Lang = "st";
                        break;
                    }
                case "Shona":
                    {
                        Lang = "sn";
                        break;
                    }
                case "Sindhi":
                    {
                        Lang = "sd";
                        break;
                    }
                case "Sinhala":
                    {
                        Lang = "si";
                        break;
                    }
                case "Slovak":
                    {
                        Lang = "sk";
                        break;
                    }
                case "Slovenian":
                    {
                        Lang = "sl";
                        break;
                    }
                case "Somali":
                    {
                        Lang = "so";
                        break;
                    }
                case "Spanish":
                    {
                        Lang = "es";
                        break;
                    }
                case "Sundanese":
                    {
                        Lang = "su";
                        break;
                    }
                case "Swahili":
                    {
                        Lang = "sw";
                        break;
                    }
                case "Swedish":
                    {
                        Lang = "sv";
                        break;
                    }
                case "Tajik":
                    {
                        Lang = "tg";
                        break;
                    }
                case "Tamil":
                    {
                        Lang = "ta";
                        break;
                    }
                case "Telugu":
                    {
                        Lang = "te";
                        break;
                    }
                case "Thai":
                    {
                        Lang = "th";
                        break;
                    }
                case "Turkish":
                    {
                        Lang = "tr";
                        break;
                    }
                case "Ukrainian":
                    {
                        Lang = "uk";
                        break;
                    }
                case "Urdu":
                    {
                        Lang = "ur";
                        break;
                    }
                case "Uzbek":
                    {
                        Lang = "uz";
                        break;
                    }
                case "Vietnamese":
                    {
                        Lang = "vi";
                        break;
                    }
                case "Welsh":
                    {
                        Lang = "cy";
                        break;
                    }
                case "Xhosa":
                    {
                        Lang = "xh";
                        break;
                    }
                case "Yiddish":
                    {
                        Lang = "yi";
                        break;
                    }
                case "Yoruba":
                    {
                        Lang = "yo";
                        break;
                    }
                case "Zulu":
                    {
                        Lang = "zu";
                        break;
                    }
                default:
                    {
                        Lang = "";
                        break;
                    }
            }
            return Lang;
        }
        #endregion

        private void buttonNavSet_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonLinkSet_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.Link[index] = textBoxLink.Text;
        }

        private void buttonAddTranslator_Click(object sender, EventArgs e)
        {
            string result = Interaction.InputBox("Enter Name of translator");
            if (result!=null)
            {
                Properties.Settings.Default.Name_Translator.Add(result.ToString());
                Properties.Settings.Default.Link.Add(String.Empty);
                Properties.Settings.Default.Xpathreceiver.Add(String.Empty);
                Properties.Settings.Default.Xpathsender.Add(String.Empty);
                Properties.Settings.Default.Save();
                comboBoxNav.Items.Clear();
                InitializeComboBox();
            }

            //Properties.Settings.Default.Websites.Add()
        }

        private void textBoxLink_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Link[index] = textBoxLink.Text;
        }

        private void textBoxXpathsender_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Xpathsender[index] = textBoxXpathsender.Text;
        }

        private void textBoxXpathreceiver_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Xpathreceiver[index] = textBoxXpathreceiver.Text;
        }

        private void Translator_config_Load(object sender, EventArgs e)
        {

        }
    }
}
