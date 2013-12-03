namespace Data_Mining
{
    partial class MainForm
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
            this.fileListPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.previewButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataSelectionPanel = new System.Windows.Forms.Panel();
            this.removeSelector = new System.Windows.Forms.Button();
            this.addSelector = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataComparsionPanel = new System.Windows.Forms.Panel();
            this.compButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.graphSelectionPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.fileListPanel.SuspendLayout();
            this.dataSelectionPanel.SuspendLayout();
            this.dataComparsionPanel.SuspendLayout();
            this.graphSelectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileListPanel
            // 
            this.fileListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileListPanel.Controls.Add(this.label1);
            this.fileListPanel.Controls.Add(this.fileListBox);
            this.fileListPanel.Controls.Add(this.previewButton);
            this.fileListPanel.Controls.Add(this.removeButton);
            this.fileListPanel.Controls.Add(this.addButton);
            this.fileListPanel.Location = new System.Drawing.Point(8, 14);
            this.fileListPanel.Name = "fileListPanel";
            this.fileListPanel.Size = new System.Drawing.Size(262, 541);
            this.fileListPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "FILE SELECTION";
            // 
            // fileListBox
            // 
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.Location = new System.Drawing.Point(7, 43);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.fileListBox.Size = new System.Drawing.Size(248, 485);
            this.fileListBox.TabIndex = 3;
            // 
            // previewButton
            // 
            this.previewButton.Location = new System.Drawing.Point(226, 11);
            this.previewButton.Name = "previewButton";
            this.previewButton.Size = new System.Drawing.Size(29, 26);
            this.previewButton.TabIndex = 2;
            this.previewButton.Text = "P";
            this.previewButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(191, 11);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(29, 26);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "-";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(156, 11);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(29, 26);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // dataSelectionPanel
            // 
            this.dataSelectionPanel.AutoScroll = true;
            this.dataSelectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataSelectionPanel.Controls.Add(this.removeSelector);
            this.dataSelectionPanel.Controls.Add(this.addSelector);
            this.dataSelectionPanel.Controls.Add(this.label2);
            this.dataSelectionPanel.Location = new System.Drawing.Point(277, 14);
            this.dataSelectionPanel.Name = "dataSelectionPanel";
            this.dataSelectionPanel.Size = new System.Drawing.Size(330, 188);
            this.dataSelectionPanel.TabIndex = 1;
            // 
            // removeSelector
            // 
            this.removeSelector.Location = new System.Drawing.Point(44, 16);
            this.removeSelector.Name = "removeSelector";
            this.removeSelector.Size = new System.Drawing.Size(32, 26);
            this.removeSelector.TabIndex = 3;
            this.removeSelector.Text = "-";
            this.removeSelector.UseVisualStyleBackColor = true;
            this.removeSelector.Click += new System.EventHandler(this.removeSelector_Click);
            // 
            // addSelector
            // 
            this.addSelector.Location = new System.Drawing.Point(6, 16);
            this.addSelector.Name = "addSelector";
            this.addSelector.Size = new System.Drawing.Size(32, 26);
            this.addSelector.TabIndex = 2;
            this.addSelector.Text = "+";
            this.addSelector.UseVisualStyleBackColor = true;
            this.addSelector.Click += new System.EventHandler(this.addSelector_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DATA SELECTION";
            // 
            // dataComparsionPanel
            // 
            this.dataComparsionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataComparsionPanel.Controls.Add(this.compButton);
            this.dataComparsionPanel.Controls.Add(this.label3);
            this.dataComparsionPanel.Controls.Add(this.checkedListBox1);
            this.dataComparsionPanel.Location = new System.Drawing.Point(277, 208);
            this.dataComparsionPanel.Name = "dataComparsionPanel";
            this.dataComparsionPanel.Size = new System.Drawing.Size(330, 108);
            this.dataComparsionPanel.TabIndex = 2;
            // 
            // compButton
            // 
            this.compButton.Location = new System.Drawing.Point(126, 28);
            this.compButton.Name = "compButton";
            this.compButton.Size = new System.Drawing.Size(140, 45);
            this.compButton.TabIndex = 2;
            this.compButton.Text = "Compare";
            this.compButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "COMPARSION";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "MAX",
            "MIN",
            "STD",
            "MEAN"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 28);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(62, 64);
            this.checkedListBox1.TabIndex = 0;
            // 
            // graphSelectionPanel
            // 
            this.graphSelectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphSelectionPanel.Controls.Add(this.label4);
            this.graphSelectionPanel.Location = new System.Drawing.Point(277, 322);
            this.graphSelectionPanel.Name = "graphSelectionPanel";
            this.graphSelectionPanel.Size = new System.Drawing.Size(330, 233);
            this.graphSelectionPanel.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "GRAPH";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 574);
            this.Controls.Add(this.graphSelectionPanel);
            this.Controls.Add(this.dataComparsionPanel);
            this.Controls.Add(this.dataSelectionPanel);
            this.Controls.Add(this.fileListPanel);
            this.Name = "MainForm";
            this.Text = "Data Mining";
            this.fileListPanel.ResumeLayout(false);
            this.fileListPanel.PerformLayout();
            this.dataSelectionPanel.ResumeLayout(false);
            this.dataSelectionPanel.PerformLayout();
            this.dataComparsionPanel.ResumeLayout(false);
            this.dataComparsionPanel.PerformLayout();
            this.graphSelectionPanel.ResumeLayout(false);
            this.graphSelectionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel fileListPanel;
        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.Button previewButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Panel dataSelectionPanel;
        private System.Windows.Forms.Panel dataComparsionPanel;
        private System.Windows.Forms.Panel graphSelectionPanel;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button compButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addSelector;
        private System.Windows.Forms.Button removeSelector;
    }
}

