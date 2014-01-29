using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Data_Mining
{
    public partial class GraphDialog : UserControl
    {
        public GraphDialog(List<ColumnSelector> columnList)
        {
            InitializeComponent();
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;

            foreach (var item in columnList)
            {
                List<double> column = Manager.prepareColumn(item.getSelectedValues()[2], item.getSelectedValues()[1]);
                Series series = chart1.Series.Add(item.getSelectedValues()[1]);
                for (int i = 0; i < column.ToArray().Length; i++)
                {
                    series.Points.AddXY(i, column.ToArray()[i]);
                }
                series.ChartType = SeriesChartType.Line;
            }

        }

        public GraphDialog(ColumnSelector xList, ColumnSelector yList)
        {
            InitializeComponent();
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;

            double[] X = Manager.prepareColumn(xList.getSelectedValues()[2], xList.getSelectedValues()[1]).ToArray();
            double[] Y = Manager.prepareColumn(yList.getSelectedValues()[2], yList.getSelectedValues()[1]).ToArray();

            if (X.Length != Y.Length)
            {
                MessageBox.Show("The size of selected columns mismatch", "?!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Series series = chart1.Series.Add(yList.getSelectedValues()[1]);
                
            for (int i = 0; i < X.Length; i++)
            {
                series.Points.AddXY(X[i], Y[i]);
            }
                
            series.ChartType = SeriesChartType.Line;
            

        }

        public GraphDialog(ColumnSelector xList, ColumnSelector yList, Boolean sort)
        {
            InitializeComponent();
            chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;

            double[] X = Manager.prepareColumn(xList.getSelectedValues()[2], xList.getSelectedValues()[1]).ToArray();
            double[] Y = Manager.prepareColumn(yList.getSelectedValues()[2], yList.getSelectedValues()[1]).ToArray();

            if (X.Length != Y.Length)
            {
                MessageBox.Show("The size of selected columns mismatch", "?!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Series series = chart1.Series.Add(yList.getSelectedValues()[1]);

            if (sort)
            {
                List<double> aux = X.ToList();
                aux.Sort();
                X = aux.ToArray();
            }

            for (int i = 0; i < X.Length; i++)
            {
                series.Points.AddXY(X[i], Y[i]);
            }

            series.ChartType = SeriesChartType.Line;


        }

    }
}
