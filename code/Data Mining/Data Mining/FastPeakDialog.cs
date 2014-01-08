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
    public partial class FastPeakDialog : Form
    {
        public FastPeakDialog(String path)
        {
            InitializeComponent();
            this.Text = Manager.getBaseInfo(path).FileName;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            this.textBox1.Text = Manager.getBaseInfo(path).Destination;
            this.textBox2.Text = Manager.getBaseInfo(path).RowCount.ToString();
            this.listBox1.Items.AddRange(Manager.getBaseInfo(path).ColumnList.ToArray());
        }
    }
}
