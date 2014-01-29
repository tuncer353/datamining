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
        List<String> maxes;
        List<String> mins;
        List<String> stds;
        List<String> means;
        bool[] chosen;
        int varChosen = 0;

        public ComparsionDialog(List<Results> results, bool[] choices)
        {
            InitializeComponent();
            DataGridView dgv = new DataGridView();
            this.maxes = new List<String>();
            this.mins = new List<String>();
            this.stds = new List<String>();
            this.means = new List<String>();
            this.chosen = choices;
            Boolean nameOk = true;
            String colName;
            int n;

            dgv.Dock = DockStyle.Fill;
            

            maxes.Add("MAX");
            mins.Add("MIN");
            stds.Add("STD");
            means.Add("MEAN");

           

            DataTable dt = new DataTable();
            dt.Columns.Add("PARAM / COLUMNS");
            foreach (var item in results)
            {
                n = 1;
                colName = item.ColName;
                do{
                    try
                    {
                        dt.Columns.Add(new DataColumn(colName));
                        nameOk = true;
                    }
                    catch (Exception e)
                    {
                        colName += "(" + n++ + ")";
                        nameOk = false;
                    }
                }while(!nameOk);
                
               /* maxes.Add(Math.Round(item.Max,5).ToString());
                mins.Add(Math.Round(item.Min,5).ToString());
                stds.Add(Math.Round(item.Std,5).ToString());
                means.Add(Math.Round(item.Avg,5).ToString());*/
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
                    this.varChosen++;
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

            this.PanelResult.Controls.Add(dgv);
            //this.Controls.Add(dgv);
        }
      

        private void ComparsionDialog_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Object[][] auxData = new Object[this.varChosen][];
            List<List<Object>> data;
            List<String> headers = new List<String>();
            DialogResult status = this.saveFileDialog1.ShowDialog();
            
            int c=0;

            if (status == DialogResult.OK)
            {
                if (this.chosen[0]) {
                    headers.Add(this.maxes.First());
                    auxData[c++] = this.maxes.ToArray<Object>();
                }
                if (this.chosen[1])
                {
                    headers.Add(this.mins.First());
                    auxData[c++] = this.mins.ToArray<Object>();
                }
                if (this.chosen[2])
                {
                    headers.Add(this.stds.First());
                    auxData[c++] = this.stds.ToArray<Object>();
                }
                if (this.chosen[3])
                {
                    headers.Add(this.means.First());
                    auxData[c++] = this.means.ToArray<Object>();
                }


                data = new List<List<Object>>();

                for (int i=1; i<auxData[0].Length; i++)
                {
                    data.Add(new List<object>());
                    data.Last().Add(auxData[0][i]);

                }

                for (int i = 1; i < auxData.Length; i++)
                {
                    for (int j = 1; j < auxData[i].Length; j++)
                    {
                        data.ElementAt(j-1).Add(auxData[i][j]);
                    }
                } 
                Data.saveFile(this.saveFileDialog1.FileName, headers, data);
            }
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

    }
}
