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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Translator));
            this.geckoWebBrowser1 = new Gecko.GeckoWebBrowser();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Target = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripTag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.paneltraducteur = new System.Windows.Forms.Panel();
            this.panelConfig_Translator = new System.Windows.Forms.Panel();
            this.radioButtonAdvenced = new System.Windows.Forms.RadioButton();
            this.radioButtonBasic = new System.Windows.Forms.RadioButton();
            this.panelAdvenced = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxXpathreceiver = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonXpathRSet = new System.Windows.Forms.Button();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.buttonLinkSet = new System.Windows.Forms.Button();
            this.buttonAddTranslator = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.dataGridViewGridListTag = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxNav = new System.Windows.Forms.ComboBox();
            this.dataGridViewTagName = new System.Windows.Forms.DataGridView();
            this.CharacterTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharacterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timerrefreshtextbox = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrersousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnaliserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.àproposdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBoxAuto = new System.Windows.Forms.CheckBox();
            this.tabControltextbox = new Manina.Windows.Forms.TabControl();
            this.tabSource = new Manina.Windows.Forms.Tab();
            this.tabTarget = new Manina.Windows.Forms.Tab();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.paneltraducteur.SuspendLayout();
            this.panelConfig_Translator.SuspendLayout();
            this.panelAdvenced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGridListTag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTagName)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControltextbox.SuspendLayout();
            this.tabSource.SuspendLayout();
            this.tabTarget.SuspendLayout();
            this.SuspendLayout();
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.Dock = System.Windows.Forms.DockStyle.Top;
            this.geckoWebBrowser1.FrameEventsPropagateToMainWindow = false;
            this.geckoWebBrowser1.Location = new System.Drawing.Point(0, 0);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.NoDefaultContextMenu = true;
            this.geckoWebBrowser1.Size = new System.Drawing.Size(1275, 461);
            this.geckoWebBrowser1.TabIndex = 0;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            this.geckoWebBrowser1.Navigated += new System.EventHandler<Gecko.GeckoNavigatedEventArgs>(this.geckoWebBrowser1_Navigated);
            this.geckoWebBrowser1.DocumentCompleted += new System.EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(this.geckoWebBrowser1_DocumentCompleted);
            this.geckoWebBrowser1.Click += new System.EventHandler(this.geckoWebBrowser1_Click);
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTranslate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonTranslate.Location = new System.Drawing.Point(1177, 746);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(107, 65);
            this.buttonTranslate.TabIndex = 2;
            this.buttonTranslate.Text = "Translate";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.button2_Click);
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
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Source,
            this.Target,
            this.Result});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 461);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(157)))), ((int)(((byte)(133)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 44;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1275, 214);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Source
            // 
            this.Source.HeaderText = "Source";
            this.Source.Name = "Source";
            this.Source.ReadOnly = true;
            this.Source.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Target
            // 
            this.Target.HeaderText = "Target";
            this.Target.Name = "Target";
            this.Target.ReadOnly = true;
            this.Target.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // contextMenuStripTag
            // 
            this.contextMenuStripTag.Name = "contextMenuStripTag";
            this.contextMenuStripTag.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStripTag.Opened += new System.EventHandler(this.contextMenuStripTag_Opened);
            // 
            // paneltraducteur
            // 
            this.paneltraducteur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneltraducteur.Controls.Add(this.dataGridView1);
            this.paneltraducteur.Controls.Add(this.geckoWebBrowser1);
            this.paneltraducteur.Location = new System.Drawing.Point(12, 27);
            this.paneltraducteur.Name = "paneltraducteur";
            this.paneltraducteur.Size = new System.Drawing.Size(1275, 675);
            this.paneltraducteur.TabIndex = 8;
            // 
            // panelConfig_Translator
            // 
            this.panelConfig_Translator.Controls.Add(this.radioButtonAdvenced);
            this.panelConfig_Translator.Controls.Add(this.radioButtonBasic);
            this.panelConfig_Translator.Controls.Add(this.panelAdvenced);
            this.panelConfig_Translator.Controls.Add(this.buttonBack);
            this.panelConfig_Translator.Controls.Add(this.dataGridViewGridListTag);
            this.panelConfig_Translator.Controls.Add(this.label3);
            this.panelConfig_Translator.Controls.Add(this.comboBoxNav);
            this.panelConfig_Translator.Controls.Add(this.dataGridViewTagName);
            this.panelConfig_Translator.Location = new System.Drawing.Point(-8, 55);
            this.panelConfig_Translator.Name = "panelConfig_Translator";
            this.panelConfig_Translator.Size = new System.Drawing.Size(1276, 584);
            this.panelConfig_Translator.TabIndex = 9;
            this.panelConfig_Translator.Visible = false;
            this.panelConfig_Translator.Click += new System.EventHandler(this.buttonXpathRSet_Click);
            // 
            // radioButtonAdvenced
            // 
            this.radioButtonAdvenced.AutoSize = true;
            this.radioButtonAdvenced.ForeColor = System.Drawing.Color.LightSlateGray;
            this.radioButtonAdvenced.Location = new System.Drawing.Point(235, 22);
            this.radioButtonAdvenced.Name = "radioButtonAdvenced";
            this.radioButtonAdvenced.Size = new System.Drawing.Size(74, 17);
            this.radioButtonAdvenced.TabIndex = 25;
            this.radioButtonAdvenced.Text = "Advenced";
            this.radioButtonAdvenced.UseVisualStyleBackColor = true;
            // 
            // radioButtonBasic
            // 
            this.radioButtonBasic.AutoSize = true;
            this.radioButtonBasic.Checked = true;
            this.radioButtonBasic.ForeColor = System.Drawing.Color.LightSlateGray;
            this.radioButtonBasic.Location = new System.Drawing.Point(235, 38);
            this.radioButtonBasic.Name = "radioButtonBasic";
            this.radioButtonBasic.Size = new System.Drawing.Size(51, 17);
            this.radioButtonBasic.TabIndex = 25;
            this.radioButtonBasic.TabStop = true;
            this.radioButtonBasic.Text = "Basic";
            this.radioButtonBasic.UseVisualStyleBackColor = true;
            this.radioButtonBasic.CheckedChanged += new System.EventHandler(this.radioButtonBasic_CheckedChanged);
            // 
            // panelAdvenced
            // 
            this.panelAdvenced.Controls.Add(this.buttonRemove);
            this.panelAdvenced.Controls.Add(this.textBoxXpathreceiver);
            this.panelAdvenced.Controls.Add(this.label5);
            this.panelAdvenced.Controls.Add(this.buttonDefault);
            this.panelAdvenced.Controls.Add(this.label1);
            this.panelAdvenced.Controls.Add(this.buttonXpathRSet);
            this.panelAdvenced.Controls.Add(this.textBoxLink);
            this.panelAdvenced.Controls.Add(this.buttonLinkSet);
            this.panelAdvenced.Controls.Add(this.buttonAddTranslator);
            this.panelAdvenced.Location = new System.Drawing.Point(360, 38);
            this.panelAdvenced.Name = "panelAdvenced";
            this.panelAdvenced.Size = new System.Drawing.Size(592, 237);
            this.panelAdvenced.TabIndex = 27;
            this.panelAdvenced.Visible = false;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(3, 46);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(56, 23);
            this.buttonRemove.TabIndex = 22;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // textBoxXpathreceiver
            // 
            this.textBoxXpathreceiver.BackColor = System.Drawing.Color.Red;
            this.textBoxXpathreceiver.Location = new System.Drawing.Point(185, 69);
            this.textBoxXpathreceiver.Name = "textBoxXpathreceiver";
            this.textBoxXpathreceiver.Size = new System.Drawing.Size(266, 20);
            this.textBoxXpathreceiver.TabIndex = 16;
            this.textBoxXpathreceiver.TextChanged += new System.EventHandler(this.textBoxXpathreceiver_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(97, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Xpath  receiver";
            // 
            // buttonDefault
            // 
            this.buttonDefault.Location = new System.Drawing.Point(457, 201);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(75, 23);
            this.buttonDefault.TabIndex = 18;
            this.buttonDefault.Text = "Default";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(97, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Link :";
            // 
            // buttonXpathRSet
            // 
            this.buttonXpathRSet.Location = new System.Drawing.Point(457, 66);
            this.buttonXpathRSet.Name = "buttonXpathRSet";
            this.buttonXpathRSet.Size = new System.Drawing.Size(75, 23);
            this.buttonXpathRSet.TabIndex = 23;
            this.buttonXpathRSet.Text = "Set";
            this.buttonXpathRSet.UseVisualStyleBackColor = true;
            this.buttonXpathRSet.Click += new System.EventHandler(this.buttonXpathRSet_Click);
            // 
            // textBoxLink
            // 
            this.textBoxLink.BackColor = System.Drawing.Color.Red;
            this.textBoxLink.Location = new System.Drawing.Point(185, 25);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(266, 20);
            this.textBoxLink.TabIndex = 20;
            this.textBoxLink.TextChanged += new System.EventHandler(this.textBoxLink_TextChanged);
            // 
            // buttonLinkSet
            // 
            this.buttonLinkSet.Location = new System.Drawing.Point(457, 23);
            this.buttonLinkSet.Name = "buttonLinkSet";
            this.buttonLinkSet.Size = new System.Drawing.Size(75, 23);
            this.buttonLinkSet.TabIndex = 24;
            this.buttonLinkSet.Text = "Set";
            this.buttonLinkSet.UseVisualStyleBackColor = true;
            this.buttonLinkSet.Click += new System.EventHandler(this.buttonLinkSet_Click_1);
            // 
            // buttonAddTranslator
            // 
            this.buttonAddTranslator.Location = new System.Drawing.Point(3, 6);
            this.buttonAddTranslator.Name = "buttonAddTranslator";
            this.buttonAddTranslator.Size = new System.Drawing.Size(56, 23);
            this.buttonAddTranslator.TabIndex = 21;
            this.buttonAddTranslator.Text = "Add";
            this.buttonAddTranslator.UseVisualStyleBackColor = true;
            this.buttonAddTranslator.Click += new System.EventHandler(this.buttonAddTranslator_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(36, 16);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 26;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
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
            this.dataGridViewGridListTag.Size = new System.Drawing.Size(373, 121);
            this.dataGridViewGridListTag.TabIndex = 25;
            this.dataGridViewGridListTag.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewGridListTag_CellEndEdit);
            this.dataGridViewGridListTag.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridViewGridListTag_RowsRemoved);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ListTag";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label3.Location = new System.Drawing.Point(165, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Translator";
            // 
            // comboBoxNav
            // 
            this.comboBoxNav.FormattingEnabled = true;
            this.comboBoxNav.Location = new System.Drawing.Point(235, 63);
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
            this.dataGridViewTagName.Size = new System.Drawing.Size(411, 121);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox1.ContextMenuStrip = this.contextMenuStripTag;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Coral;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 0);
            this.textBox1.TabIndex = 26;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // timerrefreshtextbox
            // 
            this.timerrefreshtextbox.Enabled = true;
            this.timerrefreshtextbox.Interval = 500;
            this.timerrefreshtextbox.Tick += new System.EventHandler(this.timerrefreshtextbox_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.aideToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1299, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.toolStripSeparator,
            this.enregistrerToolStripMenuItem,
            this.enregistrersousToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem.Image")));
            this.ouvrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ouvrirToolStripMenuItem.Text = "&Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(167, 6);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem.Image")));
            this.enregistrerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // enregistrersousToolStripMenuItem
            // 
            this.enregistrersousToolStripMenuItem.Name = "enregistrersousToolStripMenuItem";
            this.enregistrersousToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.enregistrersousToolStripMenuItem.Text = "Enregistrer &sous";
            this.enregistrersousToolStripMenuItem.Click += new System.EventHandler(this.enregistrersousToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(167, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // outilsToolStripMenuItem
            // 
            this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnaliserToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.rechercherToolStripMenuItem});
            this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
            this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.outilsToolStripMenuItem.Text = "&Outils";
            // 
            // personnaliserToolStripMenuItem
            // 
            this.personnaliserToolStripMenuItem.Name = "personnaliserToolStripMenuItem";
            this.personnaliserToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.personnaliserToolStripMenuItem.Text = "&Personnaliser";
            this.personnaliserToolStripMenuItem.Click += new System.EventHandler(this.personnaliserToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // rechercherToolStripMenuItem
            // 
            this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
            this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.rechercherToolStripMenuItem.Text = "&Rechercher";
            this.rechercherToolStripMenuItem.Click += new System.EventHandler(this.rechercherToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.àproposdeToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "&Aide";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(144, 6);
            // 
            // àproposdeToolStripMenuItem
            // 
            this.àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
            this.àproposdeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.àproposdeToolStripMenuItem.Text = "À &propos de...";
            this.àproposdeToolStripMenuItem.Click += new System.EventHandler(this.àproposdeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(25, 20);
            this.toolStripMenuItem1.Text = "↑";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Coral;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1157, 80);
            this.textBox2.TabIndex = 29;
            // 
            // checkBoxAuto
            // 
            this.checkBoxAuto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAuto.AutoSize = true;
            this.checkBoxAuto.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.checkBoxAuto.ForeColor = System.Drawing.Color.MistyRose;
            this.checkBoxAuto.Location = new System.Drawing.Point(1195, 723);
            this.checkBoxAuto.Name = "checkBoxAuto";
            this.checkBoxAuto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxAuto.Size = new System.Drawing.Size(89, 17);
            this.checkBoxAuto.TabIndex = 27;
            this.checkBoxAuto.Text = "Auto activate";
            this.checkBoxAuto.UseVisualStyleBackColor = true;
            this.checkBoxAuto.CheckedChanged += new System.EventHandler(this.checkBoxAuto_CheckedChanged);
            // 
            // tabControltextbox
            // 
            this.tabControltextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControltextbox.Controls.Add(this.tabSource);
            this.tabControltextbox.Controls.Add(this.tabTarget);
            this.tabControltextbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabControltextbox.Location = new System.Drawing.Point(12, 709);
            this.tabControltextbox.Name = "tabControltextbox";
            this.tabControltextbox.SelectedIndex = 0;
            this.tabControltextbox.Size = new System.Drawing.Size(1159, 102);
            this.tabControltextbox.TabIndex = 7;
            this.tabControltextbox.Tabs.Add(this.tabSource);
            this.tabControltextbox.Tabs.Add(this.tabTarget);
            // 
            // tabSource
            // 
            this.tabSource.BackColor = System.Drawing.Color.Maroon;
            this.tabSource.Controls.Add(this.textBox2);
            this.tabSource.Location = new System.Drawing.Point(1, 21);
            this.tabSource.Name = "tabSource";
            this.tabSource.Size = new System.Drawing.Size(1157, 80);
            this.tabSource.Text = "Source";
            // 
            // tabTarget
            // 
            this.tabTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tabTarget.Controls.Add(this.textBox1);
            this.tabTarget.Location = new System.Drawing.Point(0, 0);
            this.tabTarget.Name = "tabTarget";
            this.tabTarget.Size = new System.Drawing.Size(0, 0);
            this.tabTarget.Text = "Target";
            // 
            // Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1299, 817);
            this.Controls.Add(this.tabControltextbox);
            this.Controls.Add(this.checkBoxAuto);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonTranslate);
            this.Controls.Add(this.paneltraducteur);
            this.Controls.Add(this.panelConfig_Translator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Translator";
            this.Text = "PhoenixTranslate V3 alpha";
            this.MaximumSizeChanged += new System.EventHandler(this.Translator_MaximumSizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Translator_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.paneltraducteur.ResumeLayout(false);
            this.panelConfig_Translator.ResumeLayout(false);
            this.panelConfig_Translator.PerformLayout();
            this.panelAdvenced.ResumeLayout(false);
            this.panelAdvenced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGridListTag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTagName)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControltextbox.ResumeLayout(false);
            this.tabSource.ResumeLayout(false);
            this.tabSource.PerformLayout();
            this.tabTarget.ResumeLayout(false);
            this.tabTarget.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.Timer timer1;
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
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timerrefreshtextbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrersousToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnaliserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem àproposdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn Target;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBoxAuto;
        private Manina.Windows.Forms.TabControl tabControltextbox;
        private Manina.Windows.Forms.Tab tabSource;
        private Manina.Windows.Forms.Tab tabTarget;
        private System.Windows.Forms.RadioButton radioButtonAdvenced;
        private System.Windows.Forms.RadioButton radioButtonBasic;
        private System.Windows.Forms.Panel panelAdvenced;
        private Gecko.GeckoWebBrowser geckoWebBrowser1;
    }
}
