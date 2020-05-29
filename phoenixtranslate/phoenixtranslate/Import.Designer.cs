namespace phoenixtranslate
{
    partial class Import
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Cheminorigine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DossierSousDossier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fichier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TB_chemin_dossier = new System.Windows.Forms.TextBox();
            this.BT_parcourir = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.ButtonCreer = new System.Windows.Forms.Button();
            this.TextNomP = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(222, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Project name should be limited to letters or numbers.";
            this.label5.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cheminorigine,
            this.DossierSousDossier,
            this.Fichier});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(112, 255);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(577, 111);
            this.listView1.TabIndex = 33;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Cheminorigine
            // 
            this.Cheminorigine.Text = "Cheminorigine";
            // 
            // DossierSousDossier
            // 
            this.DossierSousDossier.Text = "DossierSousDossier";
            // 
            // Fichier
            // 
            this.Fichier.Text = "Fichier";
            this.Fichier.Width = 140;
            // 
            // TB_chemin_dossier
            // 
            this.TB_chemin_dossier.BackColor = System.Drawing.Color.White;
            this.TB_chemin_dossier.Location = new System.Drawing.Point(116, 133);
            this.TB_chemin_dossier.Name = "TB_chemin_dossier";
            this.TB_chemin_dossier.ReadOnly = true;
            this.TB_chemin_dossier.Size = new System.Drawing.Size(157, 20);
            this.TB_chemin_dossier.TabIndex = 32;
            this.TB_chemin_dossier.TextChanged += new System.EventHandler(this.TB_chemin_dossier_TextChanged);
            // 
            // BT_parcourir
            // 
            this.BT_parcourir.Location = new System.Drawing.Point(298, 130);
            this.BT_parcourir.Name = "BT_parcourir";
            this.BT_parcourir.Size = new System.Drawing.Size(75, 23);
            this.BT_parcourir.TabIndex = 31;
            this.BT_parcourir.Text = "Parcourir";
            this.BT_parcourir.UseVisualStyleBackColor = true;
            this.BT_parcourir.Click += new System.EventHandler(this.BT_parcourir_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(113, 116);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(125, 13);
            this.Label3.TabIndex = 30;
            this.Label3.Text = "Sélectionnez un dossier :";
            // 
            // ButtonCreer
            // 
            this.ButtonCreer.Enabled = false;
            this.ButtonCreer.Location = new System.Drawing.Point(112, 372);
            this.ButtonCreer.Name = "ButtonCreer";
            this.ButtonCreer.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreer.TabIndex = 29;
            this.ButtonCreer.Text = "Creer";
            this.ButtonCreer.UseVisualStyleBackColor = true;
            this.ButtonCreer.Click += new System.EventHandler(this.ButtonCreer_Click);
            // 
            // TextNomP
            // 
            this.TextNomP.Location = new System.Drawing.Point(116, 71);
            this.TextNomP.Name = "TextNomP";
            this.TextNomP.Size = new System.Drawing.Size(100, 20);
            this.TextNomP.TabIndex = 28;
            this.TextNomP.TextChanged += new System.EventHandler(this.TextNomP_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(113, 175);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 13);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "Liste de fichiers";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(113, 55);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(74, 13);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "Nom du Projet";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TB_chemin_dossier);
            this.Controls.Add(this.BT_parcourir);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.ButtonCreer);
            this.Controls.Add(this.TextNomP);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Import";
            this.Text = "Import";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Import_FormClosing);
            this.Load += new System.EventHandler(this.Import_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Cheminorigine;
        private System.Windows.Forms.ColumnHeader DossierSousDossier;
        private System.Windows.Forms.ColumnHeader Fichier;
        private System.Windows.Forms.TextBox TB_chemin_dossier;
        internal System.Windows.Forms.Button BT_parcourir;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button ButtonCreer;
        internal System.Windows.Forms.TextBox TextNomP;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}