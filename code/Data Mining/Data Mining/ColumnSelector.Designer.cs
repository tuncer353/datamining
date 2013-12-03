namespace Data_Mining
{
    partial class ColumnSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileList = new System.Windows.Forms.ComboBox();
            this.columnList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.Location = new System.Drawing.Point(3, 18);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(128, 21);
            this.fileList.TabIndex = 0;
            this.fileList.SelectionChangeCommitted += new System.EventHandler(this.fileList_SelectionChangeCommitted);
            // 
            // columnList
            // 
            this.columnList.FormattingEnabled = true;
            this.columnList.Location = new System.Drawing.Point(3, 77);
            this.columnList.Name = "columnList";
            this.columnList.Size = new System.Drawing.Size(128, 21);
            this.columnList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Column:";
            // 
            // ColumnSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.columnList);
            this.Controls.Add(this.fileList);
            this.Name = "ColumnSelector";
            this.Size = new System.Drawing.Size(140, 106);
            this.Load += new System.EventHandler(this.ColumnSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox fileList;
        private System.Windows.Forms.ComboBox columnList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
