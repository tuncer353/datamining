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
            openFileDialog.ShowDialog();
            listOfFiles = openFileDialog.FileNames;
            fileListBox.Items.AddRange(listOfFiles);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            fileListBox.Items.Remove(fileListBox.SelectedItem);
            fileListBox.Refresh();
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
            GraphDialog g = new GraphDialog(columnSelectorList.ToList<ColumnSelector>());
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
            List<Results> results = Manager.Compare(columnSelectorList.ToList<ColumnSelector>());
            bool[] choices = new bool[4];

            for (int i = 0; i < choices.Length; i++)
            {
                choices[i] = checkedListBox1.GetItemChecked(i);
            }

            ComparsionDialog cd = new ComparsionDialog(results, choices);
            cd.Show();
        }
    }
}
