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

    }
}
