namespace phoenixtranslate
{
    partial class Translator
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Code généré par le Concepteur Windows Form
        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.geckoWebBrowser1 = new Gecko.GeckoWebBrowser();
            this.button2 = new System.Windows.Forms.Button();
            this.buttontranslatorconfig = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paneltraducteur = new System.Windows.Forms.Panel();
            this.panelConfig_Translator = new System.Windows.Forms.Panel();
            this.dataGridViewGridListTag = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.buttonXpathRSet = new System.Windows.Forms.Button();
            this.buttonLinkSet = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAddTranslator = new System.Windows.Forms.Button();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxXpathreceiver = new System.Windows.Forms.TextBox();
            this.comboBoxNav = new System.Windows.Forms.ComboBox();
            this.dataGridViewTagName = new System.Windows.Forms.DataGridView();
            this.CharacterTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharacterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripTag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.paneltraducteur.SuspendLayout();
            this.panelConfig_Translator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGridListTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTagName)).BeginInit();
            this.SuspendLayout();
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.geckoWebBrowser1.FrameEventsPropagateToMainWindow = false;
            this.geckoWebBrowser1.Location = new System.Drawing.Point(0, 3);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.NoDefaultContextMenu = true;
            this.geckoWebBrowser1.Size = new System.Drawing.Size(1219, 291);
            this.geckoWebBrowser1.TabIndex = 0;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            this.geckoWebBrowser1.Navigated += new System.EventHandler<Gecko.GeckoNavigatedEventArgs>(this.geckoWebBrowser1_Navigated);
            this.geckoWebBrowser1.DocumentCompleted += new System.EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(this.geckoWebBrowser1_DocumentCompleted);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1162, 588);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttontranslatorconfig
            // 
            this.buttontranslatorconfig.Location = new System.Drawing.Point(38, 26);
            this.buttontranslatorconfig.Name = "buttontranslatorconfig";
            this.buttontranslatorconfig.Size = new System.Drawing.Size(75, 23);
            this.buttontranslatorconfig.TabIndex = 5;
            this.buttontranslatorconfig.Text = "Config translator";
            this.buttontranslatorconfig.UseVisualStyleBackColor = true;
            this.buttontranslatorconfig.Click += new System.EventHandler(this.buttontranslatorconfig_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Source,
            this.Target});
            this.dataGridView1.Location = new System.Drawing.Point(3, 300);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1234, 272);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // paneltraducteur
            // 
            this.paneltraducteur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneltraducteur.Controls.Add(this.geckoWebBrowser1);
            this.paneltraducteur.Controls.Add(this.button2);
            this.paneltraducteur.Controls.Add(this.dataGridView1);
            this.paneltraducteur.Location = new System.Drawing.Point(12, 55);
            this.paneltraducteur.Name = "paneltraducteur";
            this.paneltraducteur.Size = new System.Drawing.Size(1240, 614);
            this.paneltraducteur.TabIndex = 8;
            // 
            // panelConfig_Translator
            // 
            this.panelConfig_Translator.Controls.Add(this.dataGridViewGridListTag);
            this.panelConfig_Translator.Controls.Add(this.buttonDefault);
            this.panelConfig_Translator.Controls.Add(this.buttonXpathRSet);
            this.panelConfig_Translator.Controls.Add(this.buttonLinkSet);
            this.panelConfig_Translator.Controls.Add(this.buttonRemove);
            this.panelConfig_Translator.Controls.Add(this.buttonAddTranslator);
            this.panelConfig_Translator.Controls.Add(this.textBoxLink);
            this.panelConfig_Translator.Controls.Add(this.label1);
            this.panelConfig_Translator.Controls.Add(this.label5);
            this.panelConfig_Translator.Controls.Add(this.label3);
            this.panelConfig_Translator.Controls.Add(this.textBoxXpathreceiver);
            this.panelConfig_Translator.Controls.Add(this.comboBoxNav);
            this.panelConfig_Translator.Controls.Add(this.dataGridViewTagName);
            this.panelConfig_Translator.Location = new System.Drawing.Point(-8, 55);
            this.panelConfig_Translator.Name = "panelConfig_Translator";
            this.panelConfig_Translator.Size = new System.Drawing.Size(1276, 665);
            this.panelConfig_Translator.TabIndex = 9;
            this.panelConfig_Translator.Visible = false;
            this.panelConfig_Translator.Click += new System.EventHandler(this.buttonXpathRSet_Click);
            // 
            // dataGridViewGridListTag
            // 
            this.dataGridViewGridListTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewGridListTag.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewGridListTag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGridListTag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridViewGridListTag.Location = new System.Drawing.Point(200, 300);
            this.dataGridViewGridListTag.MultiSelect = false;
            this.dataGridViewGridListTag.Name = "dataGridViewGridListTag";
            this.dataGridViewGridListTag.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGridListTag.Size = new System.Drawing.Size(373, 202);
            this.dataGridViewGridListTag.TabIndex = 25;
            this.dataGridViewGridListTag.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewGridListTag_CellEndEdit);
            this.dataGridViewGridListTag.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridViewGridListTag_RowsRemoved);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ListTag";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // buttonDefault
            // 
            this.buttonDefault.Location = new System.Drawing.Point(814, 211);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(75, 23);
            this.buttonDefault.TabIndex = 18;
            this.buttonDefault.Text = "Default";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // buttonXpathRSet
            // 
            this.buttonXpathRSet.Location = new System.Drawing.Point(814, 76);
            this.buttonXpathRSet.Name = "buttonXpathRSet";
            this.buttonXpathRSet.Size = new System.Drawing.Size(75, 23);
            this.buttonXpathRSet.TabIndex = 23;
            this.buttonXpathRSet.Text = "Set";
            this.buttonXpathRSet.UseVisualStyleBackColor = true;
            // 
            // buttonLinkSet
            // 
            this.buttonLinkSet.Location = new System.Drawing.Point(814, 33);
            this.buttonLinkSet.Name = "buttonLinkSet";
            this.buttonLinkSet.Size = new System.Drawing.Size(75, 23);
            this.buttonLinkSet.TabIndex = 24;
            this.buttonLinkSet.Text = "Set";
            this.buttonLinkSet.UseVisualStyleBackColor = true;
            this.buttonLinkSet.Click += new System.EventHandler(this.buttonLinkSet_Click_1);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(360, 56);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(56, 23);
            this.buttonRemove.TabIndex = 22;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAddTranslator
            // 
            this.buttonAddTranslator.Location = new System.Drawing.Point(360, 16);
            this.buttonAddTranslator.Name = "buttonAddTranslator";
            this.buttonAddTranslator.Size = new System.Drawing.Size(56, 23);
            this.buttonAddTranslator.TabIndex = 21;
            this.buttonAddTranslator.Text = "Add";
            this.buttonAddTranslator.UseVisualStyleBackColor = true;
            this.buttonAddTranslator.Click += new System.EventHandler(this.buttonAddTranslator_Click);
            // 
            // textBoxLink
            // 
            this.textBoxLink.BackColor = System.Drawing.Color.Red;
            this.textBoxLink.Location = new System.Drawing.Point(542, 35);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(266, 20);
            this.textBoxLink.TabIndex = 20;
            this.textBoxLink.TextChanged += new System.EventHandler(this.textBoxLink_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(454, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Link :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Xpath  receiver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Translator";
            // 
            // textBoxXpathreceiver
            // 
            this.textBoxXpathreceiver.BackColor = System.Drawing.Color.Red;
            this.textBoxXpathreceiver.Location = new System.Drawing.Point(542, 79);
            this.textBoxXpathreceiver.Name = "textBoxXpathreceiver";
            this.textBoxXpathreceiver.Size = new System.Drawing.Size(266, 20);
            this.textBoxXpathreceiver.TabIndex = 16;
            this.textBoxXpathreceiver.TextChanged += new System.EventHandler(this.textBoxXpathreceiver_TextChanged);
            // 
            // comboBoxNav
            // 
            this.comboBoxNav.FormattingEnabled = true;
            this.comboBoxNav.Location = new System.Drawing.Point(233, 38);
            this.comboBoxNav.Name = "comboBoxNav";
            this.comboBoxNav.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNav.TabIndex = 14;
            this.comboBoxNav.SelectedIndexChanged += new System.EventHandler(this.comboBoxNav_SelectedIndexChanged);
            // 
            // dataGridViewTagName
            // 
            this.dataGridViewTagName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTagName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTagName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTagName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CharacterTag,
            this.CharacterName});
            this.dataGridViewTagName.Location = new System.Drawing.Point(765, 300);
            this.dataGridViewTagName.MultiSelect = false;
            this.dataGridViewTagName.Name = "dataGridViewTagName";
            this.dataGridViewTagName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTagName.Size = new System.Drawing.Size(411, 202);
            this.dataGridViewTagName.TabIndex = 8;
            this.dataGridViewTagName.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTagName_CellEndEdit);
            this.dataGridViewTagName.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridViewTagName_RowsRemoved);
            // 
            // CharacterTag
            // 
            this.CharacterTag.HeaderText = "CharacterTag";
            this.CharacterTag.Name = "CharacterTag";
            // 
            // CharacterName
            // 
            this.CharacterName.HeaderText = "CharacterName";
            this.CharacterName.Name = "CharacterName";
            // 
            // contextMenuStripTag
            // 
            this.contextMenuStripTag.Name = "contextMenuStripTag";
            this.contextMenuStripTag.Size = new System.Drawing.Size(61, 4);
            // 
            // Source
            // 
            this.Source.HeaderText = "Source";
            this.Source.Name = "Source";
            this.Source.ReadOnly = true;
            // 
            // Target
            // 
            this.Target.ContextMenuStrip = this.contextMenuStripTag;
            this.Target.HeaderText = "Target";
            this.Target.Name = "Target";
            // 
            // Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.paneltraducteur);
            this.Controls.Add(this.buttontranslatorconfig);
            this.Controls.Add(this.panelConfig_Translator);
            this.Name = "Translator";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Translator_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.paneltraducteur.ResumeLayout(false);
            this.panelConfig_Translator.ResumeLayout(false);
            this.panelConfig_Translator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGridListTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTagName)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private Gecko.GeckoWebBrowser geckoWebBrowser1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttontranslatorconfig;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel paneltraducteur;
        private System.Windows.Forms.Panel panelConfig_Translator;
        public System.Windows.Forms.DataGridView dataGridViewTagName;
        public System.Windows.Forms.DataGridViewTextBoxColumn CharacterTag;
        public System.Windows.Forms.DataGridViewTextBoxColumn CharacterName;
        private System.Windows.Forms.Button buttonDefault;
        private System.Windows.Forms.Button buttonXpathRSet;
        private System.Windows.Forms.Button buttonLinkSet;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAddTranslator;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxXpathreceiver;
        private System.Windows.Forms.ComboBox comboBoxNav;
        public System.Windows.Forms.DataGridView dataGridViewGridListTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn Target;
    }
}
