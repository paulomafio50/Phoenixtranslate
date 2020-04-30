namespace phoenixtranslate
{
    partial class Config_Tag
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
            this.dataGridViewTagName = new System.Windows.Forms.DataGridView();
            this.CharacterTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharacterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTagName)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridViewTagName.Location = new System.Drawing.Point(294, 57);
            this.dataGridViewTagName.MultiSelect = false;
            this.dataGridViewTagName.Name = "dataGridViewTagName";
            this.dataGridViewTagName.ReadOnly = true;
            this.dataGridViewTagName.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTagName.Size = new System.Drawing.Size(476, 335);
            this.dataGridViewTagName.TabIndex = 7;
            this.dataGridViewTagName.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // CharacterTag
            // 
            this.CharacterTag.HeaderText = "CharacterTag";
            this.CharacterTag.Name = "CharacterTag";
            this.CharacterTag.ReadOnly = true;
            // 
            // CharacterName
            // 
            this.CharacterName.HeaderText = "CharacterName";
            this.CharacterName.Name = "CharacterName";
            this.CharacterName.ReadOnly = true;
            // 
            // Config_Tag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTagName);
            this.Name = "Config_Tag";
            this.Text = "Config_Tag";
            this.Load += new System.EventHandler(this.Config_Tag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTagName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewTagName;
        public System.Windows.Forms.DataGridViewTextBoxColumn CharacterTag;
        public System.Windows.Forms.DataGridViewTextBoxColumn CharacterName;
    }
}