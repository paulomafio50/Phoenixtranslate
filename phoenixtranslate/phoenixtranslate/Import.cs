using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Text.RegularExpressions;

namespace phoenixtranslate
{
    public partial class Import : Form
    {
        Regex rg = new Regex("^[A-Za-z0-9_]+$");
        string DbPath = "database.db";
        public Import()
        {

            InitializeComponent();
        }

        private void Import_Load(object sender, EventArgs e)
        {

        }

        private void TextNomP_TextChanged(object sender, EventArgs e)
        {
            if (!rg.IsMatch(TextNomP.Text) & !string.IsNullOrEmpty(TextNomP.Text))
            {
                TextNomP.BackColor = Color.Red;
                label5.Visible = true;

            }

            else
            {
                TextNomP.BackColor = Color.White;
                label5.Visible = false;
            }



            Validatecreate();
        }
        private void Validatecreate()
        {
            if (TextNomP.Text.Length != 0 & TextNomP.BackColor == Color.White)
            {
                if (listView1.Items.Count > 0)
                {
                    if (rg.IsMatch(TextNomP.Text)) { ButtonCreer.Enabled = true; }

                    else { ButtonCreer.Enabled = false; }

                }
                else { ButtonCreer.Enabled = false; }

            }
            else { ButtonCreer.Enabled = false; }
        }

        private void TB_chemin_dossier_TextChanged(object sender, EventArgs e)
        {

        }

        private void BT_parcourir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() != DialogResult.OK) return;



            string dossier = FBD.SelectedPath;

            TB_chemin_dossier.Text = FBD.SelectedPath;

            //Recup Dossier pour save
            String folder = Path.GetDirectoryName(FBD.SelectedPath);
            //

            string[] allfiles = Directory.GetFiles(FBD.SelectedPath, "*.rpy", SearchOption.AllDirectories);
            foreach (string file in allfiles)
            {
                //RpyFileModel fichier = RpyFileModel.Load(file);

                //Recup extension
                string extension = Path.GetExtension(file);
                //

                // recup le nom du fichier0
                String namefile = Path.GetFileNameWithoutExtension(file);
                //

                //Recup DossierSousDossier pour save as
                String foldersubfolder = file.Replace(folder, "").Replace(Path.GetFileName(file), "");
                //

                //ajoute la row
                string[] row = { folder + foldersubfolder + namefile + extension };

                listView1.Items.Add(new ListViewItem(row));
                //
            }
            Validatecreate();
        }

        private void ButtonCreer_Click(object sender, EventArgs e)
        {
            Translator f1 = (Translator)this.Owner;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
            }
            foreach (ListViewItem item in listView1.Items)
            {
                string contents;
                using (StreamReader reader = new StreamReader(item.Text))
                {
                    contents = reader.ReadToEnd();
                    //^# game.+\\d+\\s+translate.+\\:\\s*# +(?<character>.+?)? *\\\"(?<text>.+?)\\\".*\\s*(?<character2>.+?)? *\\\"(?<text2>.+?)\\\".*$
                    //^                                                                \\s*# +(?<character>.+?)? *\\\"(?<text>.+?)\\\".*\\s*(?<character2>.+?)? *\\\"(?<text2>.+?)\\\".*$
                    //^((# TODO: Translation updated.+\d+\s+)?# game.+\d+\s+translate.+:\s*# +(?<character>.+?)? *"(?<text>.+?)".*\s*(?<character2>.+?)? *")(?<text2>.+?)(".*)$
                    //^\\s*old *\\\"(?<old>.+?)\\\"\\s+new *\\\"(?<new>.+?)\\\"\\s+
                    Match match = Regex.Match(contents, "^((# TODO: Translation updated.+\\d+\\s+)?# game.+\\d+\\s+translate.+:\\s*# +(?<character>.+?)? *\\\"(?<text>.+?)\\\".*\\s*(?<character2>.+?)? *\\\")(?<text2>.+?)(\\\".*)$", RegexOptions.Multiline);
                    Match match2 = Regex.Match(contents, "^(translate.+ strings:)?\\s +# game.+\\d+\\s*old *\\\"(?<old>.+?)\\\"\\s+new *\\\"(?<new>.+?)", RegexOptions.Multiline);
                    while (match.Success)
                    {
                      
                        f1.dataGridView1.Rows.Add(match.Groups["text"].Value, match.Groups["text2"].Value,match.Value);

                        match = match.NextMatch();
                    }

                    while (match2.Success)
                    {
                        f1.dataGridView1.Rows.Add(match2.Groups["old"].Value, match2.Groups["new"].Value, match.Value);
                        match2 = match2.NextMatch();
                    }

                }


            }
            this.Owner.Show();
            this.Hide();
        }

        private void Import_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.Owner.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Translator f1 = (Translator)this.Owner;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                //}
                //foreach (ListViewItem item in listView1.Items)
                //{
                string contents;
                using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                {
                    contents = reader.ReadToEnd();
                    //^# game.+\\d+\\s+translate.+\\:\\s*# +(?<character>.+?)? *\\\"(?<text>.+?)\\\".*\\s*(?<character2>.+?)? *\\\"(?<text2>.+?)\\\".*$
                    //^                                                                \\s*# +(?<character>.+?)? *\\\"(?<text>.+?)\\\".*\\s*(?<character2>.+?)? *\\\"(?<text2>.+?)\\\".*$
                    //^((# TODO: Translation updated.+\d+\s+)?# game.+\d+\s+translate.+:\s*# +(?<character>.+?)? *"(?<text>.+?)".*\s*(?<character2>.+?)? *")(?<text2>.+?)(".*)$
                    //^\\s*old *\\\"(?<old>.+?)\\\"\\s+new *\\\"(?<new>.+?)\\\"\\s+
                    Match match = Regex.Match(contents, "^((# TODO: Translation updated.+\\d+\\s+)?# game.+\\d+\\s+translate.+:\\s*# +(?<character>.+?)? *\\\"(?<text>.+?)\\\".*\\s*(?<character2>.+?)? *\\\")(?<text2>.+?)(\\\".*)$", RegexOptions.Multiline);
                    Match match2 = Regex.Match(contents, "^(translate.+ strings:)?\\s +# game.+\\d+\\s*old *\\\"(?<old>.+?)\\\"\\s+new *\\\"(?<new>.+?)", RegexOptions.Multiline);
                    while (match.Success)
                    {

                        f1.dataGridView1.Rows.Add(match.Groups["text"].Value, match.Groups["text2"].Value, match.Value);

                        match = match.NextMatch();
                    }

                    while (match2.Success)
                    {
                        f1.dataGridView1.Rows.Add(match2.Groups["old"].Value, match2.Groups["new"].Value, match.Value);
                        match2 = match2.NextMatch();
                    }

                }


            }
            this.Owner.Show();
            this.Hide();
        }
    }
    
}
