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
    }
}
