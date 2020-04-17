namespace phoenixtranslate
{
    partial class Translator_config
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
            this.comboBoxNav = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxXpathsender = new System.Windows.Forms.TextBox();
            this.textBoxXpathreceiver = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonXpathRSet = new System.Windows.Forms.Button();
            this.buttonXpathSSet = new System.Windows.Forms.Button();
            this.buttonLinkSet = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAddTranslator = new System.Windows.Forms.Button();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonQuerySet = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.textBoxQuerysender = new System.Windows.Forms.TextBox();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxNav
            // 
            this.comboBoxNav.FormattingEnabled = true;
            this.comboBoxNav.Location = new System.Drawing.Point(118, 34);
            this.comboBoxNav.Name = "comboBoxNav";
            this.comboBoxNav.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNav.TabIndex = 3;
            this.comboBoxNav.SelectedIndexChanged += new System.EventHandler(this.comboBoxNav_SelectedIndexChanged);
            this.comboBoxNav.SelectionChangeCommitted += new System.EventHandler(this.comboBoxNav_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Translator";
            // 
            // textBoxXpathsender
            // 
            this.textBoxXpathsender.BackColor = System.Drawing.Color.Red;
            this.textBoxXpathsender.Location = new System.Drawing.Point(427, 69);
            this.textBoxXpathsender.Name = "textBoxXpathsender";
            this.textBoxXpathsender.Size = new System.Drawing.Size(266, 20);
            this.textBoxXpathsender.TabIndex = 6;
            this.textBoxXpathsender.TextChanged += new System.EventHandler(this.textBoxXpathsender_TextChanged);
            // 
            // textBoxXpathreceiver
            // 
            this.textBoxXpathreceiver.BackColor = System.Drawing.Color.Red;
            this.textBoxXpathreceiver.Location = new System.Drawing.Point(427, 152);
            this.textBoxXpathreceiver.Name = "textBoxXpathreceiver";
            this.textBoxXpathreceiver.Size = new System.Drawing.Size(266, 20);
            this.textBoxXpathreceiver.TabIndex = 6;
            this.textBoxXpathreceiver.TextChanged += new System.EventHandler(this.textBoxXpathreceiver_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonQuerySet);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.textBoxQuerysender);
            this.panel1.Controls.Add(this.buttonXpathRSet);
            this.panel1.Controls.Add(this.buttonXpathSSet);
            this.panel1.Controls.Add(this.buttonLinkSet);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.buttonAddTranslator);
            this.panel1.Controls.Add(this.textBoxLink);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxXpathreceiver);
            this.panel1.Controls.Add(this.textBoxXpathsender);
            this.panel1.Controls.Add(this.comboBoxNav);
            this.panel1.Location = new System.Drawing.Point(7, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 195);
            this.panel1.TabIndex = 7;
            // 
            // buttonXpathRSet
            // 
            this.buttonXpathRSet.Location = new System.Drawing.Point(699, 149);
            this.buttonXpathRSet.Name = "buttonXpathRSet";
            this.buttonXpathRSet.Size = new System.Drawing.Size(75, 23);
            this.buttonXpathRSet.TabIndex = 13;
            this.buttonXpathRSet.Text = "Set";
            this.buttonXpathRSet.UseVisualStyleBackColor = true;
            this.buttonXpathRSet.Click += new System.EventHandler(this.buttonXpathRSet_Click);
            // 
            // buttonXpathSSet
            // 
            this.buttonXpathSSet.Location = new System.Drawing.Point(699, 69);
            this.buttonXpathSSet.Name = "buttonXpathSSet";
            this.buttonXpathSSet.Size = new System.Drawing.Size(75, 23);
            this.buttonXpathSSet.TabIndex = 13;
            this.buttonXpathSSet.Text = "Set";
            this.buttonXpathSSet.UseVisualStyleBackColor = true;
            this.buttonXpathSSet.Click += new System.EventHandler(this.buttonXpathSSet_Click);
            // 
            // buttonLinkSet
            // 
            this.buttonLinkSet.Location = new System.Drawing.Point(699, 29);
            this.buttonLinkSet.Name = "buttonLinkSet";
            this.buttonLinkSet.Size = new System.Drawing.Size(75, 23);
            this.buttonLinkSet.TabIndex = 13;
            this.buttonLinkSet.Text = "Set";
            this.buttonLinkSet.UseVisualStyleBackColor = true;
            this.buttonLinkSet.Click += new System.EventHandler(this.buttonLinkSet_Click_1);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(245, 52);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(56, 23);
            this.buttonRemove.TabIndex = 12;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAddTranslator
            // 
            this.buttonAddTranslator.Location = new System.Drawing.Point(245, 12);
            this.buttonAddTranslator.Name = "buttonAddTranslator";
            this.buttonAddTranslator.Size = new System.Drawing.Size(56, 23);
            this.buttonAddTranslator.TabIndex = 11;
            this.buttonAddTranslator.Text = "Add";
            this.buttonAddTranslator.UseVisualStyleBackColor = true;
            this.buttonAddTranslator.Click += new System.EventHandler(this.buttonAddTranslator_Click);
            // 
            // textBoxLink
            // 
            this.textBoxLink.BackColor = System.Drawing.Color.Red;
            this.textBoxLink.Location = new System.Drawing.Point(427, 31);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(266, 20);
            this.textBoxLink.TabIndex = 10;
            this.textBoxLink.TextChanged += new System.EventHandler(this.textBoxLink_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Link :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Xpath  receiver";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Xpath sender";
            // 
            // buttonQuerySet
            // 
            this.buttonQuerySet.Location = new System.Drawing.Point(699, 101);
            this.buttonQuerySet.Name = "buttonQuerySet";
            this.buttonQuerySet.Size = new System.Drawing.Size(75, 23);
            this.buttonQuerySet.TabIndex = 16;
            this.buttonQuerySet.Text = "Set";
            this.buttonQuerySet.UseVisualStyleBackColor = true;
            this.buttonQuerySet.Click += new System.EventHandler(this.buttonQuerySet_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(339, 104);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(70, 13);
            this.label.TabIndex = 15;
            this.label.Text = "Query sender";
            // 
            // textBoxQuerysender
            // 
            this.textBoxQuerysender.BackColor = System.Drawing.Color.Red;
            this.textBoxQuerysender.Location = new System.Drawing.Point(427, 101);
            this.textBoxQuerysender.Name = "textBoxQuerysender";
            this.textBoxQuerysender.Size = new System.Drawing.Size(266, 20);
            this.textBoxQuerysender.TabIndex = 14;
            this.textBoxQuerysender.TextChanged += new System.EventHandler(this.textBoxQuerysender_TextChanged);
            // 
            // buttonDefault
            // 
            this.buttonDefault.Location = new System.Drawing.Point(685, 293);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(75, 23);
            this.buttonDefault.TabIndex = 9;
            this.buttonDefault.Text = "Default";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // Translator_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDefault);
            this.Controls.Add(this.panel1);
            this.Name = "Translator_config";
            this.Text = "Translator_config";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Translator_config_FormClosing);
            this.Load += new System.EventHandler(this.Translator_config_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxNav;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxXpathsender;
        private System.Windows.Forms.TextBox textBoxXpathreceiver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddTranslator;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonXpathRSet;
        private System.Windows.Forms.Button buttonXpathSSet;
        private System.Windows.Forms.Button buttonLinkSet;
        private System.Windows.Forms.Button buttonQuerySet;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxQuerysender;
        private System.Windows.Forms.Button buttonDefault;
    }
}