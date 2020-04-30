using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phoenixtranslate
{
    public partial class Config_Tag : Form
    {
        private Translator _Translator;
        public Config_Tag(Translator translator)

        {
            InitializeComponent();
            this._Translator = translator;
        }

        private void Config_Tag_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string result = Microsoft.VisualBasic.Interaction.InputBox("Enter the tag ex:[player1]");
            if (!string.IsNullOrEmpty(result))
            {
                string result2 = Microsoft.VisualBasic.Interaction.InputBox("Enter replacement tag ex: Jack");
                if (!string.IsNullOrEmpty(result2))
                {
                    dataGridViewTagName.Rows.Add(result, result2);
                }
            }

        }
    }
}