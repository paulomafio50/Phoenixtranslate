using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Windows.Forms;
namespace phoenixtranslate
{
    public partial class Translator_config : Form
    {
        public int index =Properties.Settings.Default.index;
        private Translator _Translator;
        public Translator_config(Translator translator)
        
        {

            InitializeComponent();
            this._Translator = translator;
            InitializeComboBox();
        }
        private void InitializeComboBox()
        {

          
            if (Properties.Settings.Default.Name_Translator.Cast<string>().ToArray().Length >= 1)
            {
                comboBoxNav.DataSource = Properties.Settings.Default.Name_Translator.Cast<string>().ToArray();

          
                comboBoxNav.SelectedIndex = index;
                textBoxLink.Text = Properties.Settings.Default.Link[index];
                textBoxXpathsender.Text = Properties.Settings.Default.Xpathsender[index];
                textBoxXpathreceiver.Text = Properties.Settings.Default.Xpathreceiver[index];
                
            }
            else
            {
                textBoxLink.Text = string.Empty;
                textBoxXpathsender.Text = string.Empty;
                textBoxXpathreceiver.Text= string.Empty;
                comboBoxNav.SelectedIndex = -1;
            }

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
                index=comboBoxNav.Items.Count;
                InitializeComboBox();


            }

        
        }



        private void Translator_config_Load(object sender, EventArgs e)
        {
    
         
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (comboBoxNav.SelectedIndex >= 0) 
            {
                Properties.Settings.Default.Name_Translator.RemoveAt(comboBoxNav.SelectedIndex);
                Properties.Settings.Default.Link.RemoveAt(comboBoxNav.SelectedIndex);
                Properties.Settings.Default.Xpathreceiver.RemoveAt(comboBoxNav.SelectedIndex);
                Properties.Settings.Default.Xpathsender.RemoveAt(comboBoxNav.SelectedIndex);
                Properties.Settings.Default.Save();
                comboBoxNav.DataSource=null;
                if (index != 0)
                {
                    index = index - 1;
                }
                   
           
                
                InitializeComboBox();


            }
            
        }



        private void comboBoxNav_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Properties.Settings.Default.index = comboBoxNav.SelectedIndex;
            
            Properties.Settings.Default.Save();
            index = Properties.Settings.Default.index;
            textBoxLink.Text = Properties.Settings.Default.Link[comboBoxNav.SelectedIndex];
            textBoxXpathsender.Text=Properties.Settings.Default.Xpathsender[comboBoxNav.SelectedIndex];
            textBoxXpathreceiver.Text=Properties.Settings.Default.Xpathreceiver[comboBoxNav.SelectedIndex];
            this._Translator.wb1.Navigate(Properties.Settings.Default.Link[index].ToString());


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

        private void buttonXpathRSet_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Xpathreceiver[comboBoxNav.SelectedIndex] = textBoxXpathreceiver.Text;
            Properties.Settings.Default.Save();

        }
    }
}
