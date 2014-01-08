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
    public partial class ComparsionDialog : Form
    {
        public ComparsionDialog(List<Results> results, bool[] choices)
        {
            InitializeComponent();
            DataGridView dgv = new DataGridView();
            List<String> maxes = new List<String>();
            List<String> mins = new List<String>();
            List<String> stds = new List<String>();
            List<String> means = new List<String>();
            dgv.Dock = DockStyle.Fill;

            maxes.Add("MAX");
            mins.Add("MIN");
            stds.Add("STD");
            means.Add("MEAN");

            DataTable dt = new DataTable();
            dt.Columns.Add("PARAM / COLUMNS");
            foreach (var item in results)
            {
                dt.Columns.Add(new DataColumn((item).ColName));

                maxes.Add(item.Max.ToString());
                mins.Add(item.Min.ToString());
                stds.Add(item.Std.ToString());
                means.Add(item.Avg.ToString());
            }

            for (int i = 0; i < choices.Length; i++)
            {
                if (choices[i])
                {
                    dt.Rows.Add();
                }
            }
            int q = 0;

            for (int i = 0; i <= results.Count; i++)
            {
                if (choices[0])
                {
                    dt.Rows[q++][i] = maxes[i];                
                }
                if (choices[1])
                {
                    dt.Rows[q++][i] = mins[i];
                }
                if (choices[2])
                {
                    dt.Rows[q++][i] = stds[i];
                }
                if (choices[3])
                {
                    dt.Rows[q++][i] = means[i];
                }
                q = 0;
            }

            dgv.DataSource = dt;

            this.Controls.Add(dgv);
        }
    }
}
