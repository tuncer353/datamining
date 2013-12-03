using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        String[] listOfFiles = { "123", "111", "231", "123", "111", "231", "123", "111", "231", "123", "111", "231"};
        public MainForm()
        {
            InitializeComponent();
            columnSelectorList = new LinkedList<ColumnSelector>();
            fileListBox.Items.AddRange(listOfFiles);
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
                MessageBox.Show("Select a file!", "?!", MessageBoxButtons.OK ,MessageBoxIcon.Information);
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
    }
}
