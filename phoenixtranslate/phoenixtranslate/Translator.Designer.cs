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
            this.contextMenuwb1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gfdgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fggdggfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.buttontranslatorconfig = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonConfigTag = new System.Windows.Forms.Button();
            this.contextMenuwb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.geckoWebBrowser1.ContextMenuStrip = this.contextMenuwb1;
            this.geckoWebBrowser1.FrameEventsPropagateToMainWindow = false;
            this.geckoWebBrowser1.Location = new System.Drawing.Point(38, 79);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.NoDefaultContextMenu = true;
            this.geckoWebBrowser1.Size = new System.Drawing.Size(1145, 502);
            this.geckoWebBrowser1.TabIndex = 0;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            this.geckoWebBrowser1.Navigated += new System.EventHandler<Gecko.GeckoNavigatedEventArgs>(this.geckoWebBrowser1_Navigated);
            this.geckoWebBrowser1.DocumentCompleted += new System.EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(this.geckoWebBrowser1_DocumentCompleted);
            this.geckoWebBrowser1.ShowContextMenu += new System.EventHandler<Gecko.GeckoContextMenuEventArgs>(this.geckoWebBrowser1_ShowContextMenu);
            // 
            // contextMenuwb1
            // 
            this.contextMenuwb1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.gfdgToolStripMenuItem,
            this.fggdggfToolStripMenuItem});
            this.contextMenuwb1.Name = "contextMenuStrip1";
            this.contextMenuwb1.Size = new System.Drawing.Size(118, 70);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.openToolStripMenuItem.Text = "open";
            // 
            // gfdgToolStripMenuItem
            // 
            this.gfdgToolStripMenuItem.Name = "gfdgToolStripMenuItem";
            this.gfdgToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.gfdgToolStripMenuItem.Text = "gfdg";
            // 
            // fggdggfToolStripMenuItem
            // 
            this.fggdggfToolStripMenuItem.Name = "fggdggfToolStripMenuItem";
            this.fggdggfToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.fggdggfToolStripMenuItem.Text = "fggdggf";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1108, 766);
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
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Source,
            this.Target});
            this.dataGridView1.Location = new System.Drawing.Point(38, 598);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 162);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Source
            // 
            this.Source.HeaderText = "Source";
            this.Source.Name = "Source";
            this.Source.ReadOnly = true;
            // 
            // Target
            // 
            this.Target.HeaderText = "Target";
            this.Target.Name = "Target";
            // 
            // buttonConfigTag
            // 
            this.buttonConfigTag.Location = new System.Drawing.Point(157, 26);
            this.buttonConfigTag.Name = "buttonConfigTag";
            this.buttonConfigTag.Size = new System.Drawing.Size(75, 23);
            this.buttonConfigTag.TabIndex = 7;
            this.buttonConfigTag.Text = "Config Tag";
            this.buttonConfigTag.UseVisualStyleBackColor = true;
            this.buttonConfigTag.Click += new System.EventHandler(this.buttonConfigTag_Click);
            // 
            // Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 857);
            this.ContextMenuStrip = this.contextMenuwb1;
            this.Controls.Add(this.buttonConfigTag);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttontranslatorconfig);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.geckoWebBrowser1);
            this.Name = "Translator";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Translator_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuwb1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private Gecko.GeckoWebBrowser geckoWebBrowser1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttontranslatorconfig;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuwb1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn Target;
        private System.Windows.Forms.ToolStripMenuItem gfdgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fggdggfToolStripMenuItem;
        private System.Windows.Forms.Button buttonConfigTag;
    }
}
