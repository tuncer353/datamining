using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Mining
{
    public partial class ColumnSelector : UserControl
    {
        public ColumnSelector(String [] fileNames, Point position)
        {
            InitializeComponent();
            this.Location = position;
            this.fileList.Items.AddRange(fileNames);
            this.Controls.Add(fileList);
        }

        private void fileList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

                foreach (var item in fileList.Items)
                {
                    String destination = item.ToString();
                    Object[] data = Data.CreateData(destination).ColumnNames.ToArray();
                    columnList.Items.AddRange(data);
                }
                this.Controls.Add(columnList);
            }
            catch (NullReferenceException ex)
            {

            }
        }

        public String[] getSelectedValues(){
            String[] selectedValues = new String[3];
            selectedValues[0] = fileList.Text;
            selectedValues[1] = columnList.Text;
            selectedValues[2] = fileList.Text;
            return selectedValues;
        }

        private void ColumnSelector_Load(object sender, EventArgs e)
        {
            
        }
    }
}
