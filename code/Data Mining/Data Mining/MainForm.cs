using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Mining
{
    public partial class MainForm : Form
    {
        private LinkedList<ColumnSelector> columnSelectorList;
        String[] listOfFiles;
        public MainForm()
        {
            InitializeComponent();
            columnSelectorList = new LinkedList<ColumnSelector>();
        }

        private void addSelector_Click(object sender, EventArgs e)
        {
            if (fileListBox.SelectedItems.Count != 0)
            {
                var a = fileListBox.SelectedItems.Cast<string>().ToList();
                String [] files = new String[a.Count];
                for (int i = 0; i < files.Length; i++)
                {
                    files[i] = a[i];
                }
                if (columnSelectorList.Count == 0)
                {
                    ColumnSelector selector = new ColumnSelector(files, new Point(10, 50));
                    dataSelectionPanel.Controls.Add(selector);
                    columnSelectorList.AddLast(selector);
                }
                else
                {
                    Point p = columnSelectorList.Last<ColumnSelector>().Location;
                    p.X += columnSelectorList.Last<ColumnSelector>().Width;
                    ColumnSelector selector = new ColumnSelector(files, p);
                    dataSelectionPanel.Controls.Add(selector);
                    columnSelectorList.AddLast(selector);
                }
            }
            else
            {
                MessageBox.Show("Select a file!", "?!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void removeSelector_Click(object sender, EventArgs e)
        {
            if (columnSelectorList.Count != 0)
            {
                columnSelectorList.Last.Value.Dispose();
                columnSelectorList.RemoveLast();
            }
            else
            {
                MessageBox.Show("There is no selector!", "?!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DialogResult status;
            if (this.batchSel.Checked)
            {
                status = this.folderBrowserDialog1.ShowDialog();
                if (status == DialogResult.OK)
                {
                    this.fileListBox.Items.Add(folderBrowserDialog1.SelectedPath);
                }

            }
            else
            {
                status = openFileDialog.ShowDialog();
                if (status == DialogResult.OK)
                {
                    listOfFiles = openFileDialog.FileNames;
                    fileListBox.Items.AddRange(listOfFiles);
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (this.batchSel.Checked)
            {

            }
            else
            {
                fileListBox.Items.Remove(fileListBox.SelectedItem);
                fileListBox.Refresh();
            }
        }
        private PerformanceCounter theCPUCounter =
            new PerformanceCounter("Processor", "% Processor Time", "_Total");

        private PerformanceCounter theMemCounter =
            new PerformanceCounter("Memory", "Available MBytes");


        private void timer1_Tick(object sender, EventArgs e)
        {
            float cpuUsage = theCPUCounter.NextValue();

            float memoryUsage = theMemCounter.NextValue() / GC.GetTotalMemory(false);

            chart1.Series[0].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            chart1.Series[0].Points[0].XValue = 1;
            chart1.Series[0].Points[1].XValue = 2;

            chart1.Series[0].Points[0].SetValueY(memoryUsage);
            chart1.Series[0].Points[1].SetValueY(cpuUsage);
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            GraphDialog g;
            if (this.XYGraphCheck.Checked && columnSelectorList.Count() >= 2)
            { 
                g = new GraphDialog(columnSelectorList.ToList<ColumnSelector>().ElementAt(0),
                    columnSelectorList.ToList<ColumnSelector>().ElementAt(1), true); 
            }
            else
            {
                g = new GraphDialog(columnSelectorList.ToList<ColumnSelector>());
            }
            
            Form graph = new Form();
            graph.Controls.Add(g);
            graph.Refresh();
            graph.Size = new Size(g.Size.Width, g.Size.Height + 20);
            graph.Show();
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            FastPeakDialog fpd = new FastPeakDialog(fileListBox.SelectedItem.ToString());
            fpd.Show();
        }

        private void compButton_Click(object sender, EventArgs e)
        {
            List<Results> results;
            bool measuSel = false;
            bool[] choices = new bool[4];

            if (this.fileListBox.SelectedItems.Count == 0 || (this.columnSelectorList.Count == 0 && !this.batchSel.Checked))
            {
                MessageBox.Show("Select the file or folder to be analyzed!", "?!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            for (int i = 0; i < choices.Length; i++)
            {
                choices[i] = checkedListBox1.GetItemChecked(i);
                measuSel |= choices[i];
            }

            if (!measuSel)
            {
                MessageBox.Show("Must be selected at least one measure!", "?!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            if(this.batchSel.Checked){
                results = Manager.Compare(this.fileListBox.SelectedItems.Cast<String>().ToList(), this.diffCheck.Checked);

            }
            else{
                results = Manager.Compare(columnSelectorList.ToList<ColumnSelector>(), this.diffCheck.Checked);
            }

            if (results != null)
            {
                ComparsionDialog cd = new ComparsionDialog(results, choices);
                cd.Show();
            }
        }

        private void bachSel_CheckedChanged(object sender, EventArgs e)
        {
            this.addSelector.Enabled = !this.batchSel.Checked;
            this.removeSelector.Enabled = !this.batchSel.Checked;
            this.graphButton.Enabled = !this.batchSel.Checked;
            this.XYGraphCheck.Enabled = !this.batchSel.Checked;
            
        }
    }
}
