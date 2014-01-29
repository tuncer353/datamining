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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 0D);
            this.fileListPanel = new System.Windows.Forms.Panel();
            this.batchSel = new System.Windows.Forms.CheckBox();
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
            this.XYGraphCheck = new System.Windows.Forms.CheckBox();
            this.graphButton = new System.Windows.Forms.Button();
            this.compButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.graphSelectionPanel = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.diffCheck = new System.Windows.Forms.CheckBox();
            this.fileListPanel.SuspendLayout();
            this.dataSelectionPanel.SuspendLayout();
            this.dataComparsionPanel.SuspendLayout();
            this.graphSelectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileListPanel
            // 
            this.fileListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileListPanel.Controls.Add(this.batchSel);
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
            // batchSel
            // 
            this.batchSel.AutoSize = true;
            this.batchSel.Location = new System.Drawing.Point(7, 17);
            this.batchSel.Name = "batchSel";
            this.batchSel.Size = new System.Drawing.Size(95, 17);
            this.batchSel.TabIndex = 5;
            this.batchSel.Text = "Batch Process";
            this.batchSel.UseVisualStyleBackColor = true;
            this.batchSel.CheckedChanged += new System.EventHandler(this.bachSel_CheckedChanged);
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
            this.previewButton.Click += new System.EventHandler(this.previewButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(191, 11);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(29, 26);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "-";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(156, 11);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(29, 26);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            this.dataSelectionPanel.Size = new System.Drawing.Size(355, 188);
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
            this.dataComparsionPanel.Controls.Add(this.diffCheck);
            this.dataComparsionPanel.Controls.Add(this.XYGraphCheck);
            this.dataComparsionPanel.Controls.Add(this.graphButton);
            this.dataComparsionPanel.Controls.Add(this.compButton);
            this.dataComparsionPanel.Controls.Add(this.label3);
            this.dataComparsionPanel.Controls.Add(this.checkedListBox1);
            this.dataComparsionPanel.Location = new System.Drawing.Point(277, 208);
            this.dataComparsionPanel.Name = "dataComparsionPanel";
            this.dataComparsionPanel.Size = new System.Drawing.Size(355, 108);
            this.dataComparsionPanel.TabIndex = 2;
            // 
            // XYGraphCheck
            // 
            this.XYGraphCheck.AutoSize = true;
            this.XYGraphCheck.Location = new System.Drawing.Point(220, 79);
            this.XYGraphCheck.Name = "XYGraphCheck";
            this.XYGraphCheck.Size = new System.Drawing.Size(110, 17);
            this.XYGraphCheck.TabIndex = 4;
            this.XYGraphCheck.Text = "X-Y First two cols.";
            this.XYGraphCheck.UseVisualStyleBackColor = true;
            // 
            // graphButton
            // 
            this.graphButton.Location = new System.Drawing.Point(220, 28);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(125, 45);
            this.graphButton.TabIndex = 3;
            this.graphButton.Text = "Draw Graph";
            this.graphButton.UseVisualStyleBackColor = true;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // compButton
            // 
            this.compButton.Location = new System.Drawing.Point(72, 28);
            this.compButton.Name = "compButton";
            this.compButton.Size = new System.Drawing.Size(125, 45);
            this.compButton.TabIndex = 2;
            this.compButton.Text = "Compare";
            this.compButton.UseVisualStyleBackColor = true;
            this.compButton.Click += new System.EventHandler(this.compButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "OPERATIONS";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
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
            this.graphSelectionPanel.Controls.Add(this.chart1);
            this.graphSelectionPanel.Controls.Add(this.label4);
            this.graphSelectionPanel.Location = new System.Drawing.Point(277, 322);
            this.graphSelectionPanel.Name = "graphSelectionPanel";
            this.graphSelectionPanel.Size = new System.Drawing.Size(355, 233);
            this.graphSelectionPanel.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea1.AxisY.Maximum = 100D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(-1, 29);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.SystemColors.Window;
            series1.MarkerBorderColor = System.Drawing.Color.Black;
            series1.MarkerColor = System.Drawing.Color.Lime;
            series1.MarkerImageTransparentColor = System.Drawing.Color.Lime;
            series1.Name = "Series1";
            dataPoint1.AxisLabel = "Memory";
            dataPoint1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataPoint2.AxisLabel = "CPU";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(351, 203);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "RESOURCE USAGE";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Data files|*.txt";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "Open file";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // diffCheck
            // 
            this.diffCheck.AutoSize = true;
            this.diffCheck.Location = new System.Drawing.Point(72, 80);
            this.diffCheck.Name = "diffCheck";
            this.diffCheck.Size = new System.Drawing.Size(121, 17);
            this.diffCheck.TabIndex = 5;
            this.diffCheck.Text = "Differ. First two cols.";
            this.diffCheck.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 574);
            this.Controls.Add(this.graphSelectionPanel);
            this.Controls.Add(this.dataComparsionPanel);
            this.Controls.Add(this.dataSelectionPanel);
            this.Controls.Add(this.fileListPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button graphButton;
        private System.Windows.Forms.CheckBox XYGraphCheck;
        private System.Windows.Forms.CheckBox batchSel;
        private System.Windows.Forms.CheckBox diffCheck;
    }
}

