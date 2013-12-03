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
            this.fileList.Items.AddRange((String [] )fileNames);
            this.Controls.Add(fileList);
        }

        private void fileList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ////TO DO
            this.columnList.Items.AddRange(new String[] {"ta","asdas"});// to ma byc zczytane z pliku:)
            ////
            this.Controls.Add(columnList);
        }

        public String[] getSelectedValues(){
            String[] selectedValues = new String[2];
            selectedValues[0] = fileList.SelectedText;
            selectedValues[1] = columnList.SelectedText;
            return selectedValues;
        }

        private void ColumnSelector_Load(object sender, EventArgs e)
        {
            
        }
    }
}
