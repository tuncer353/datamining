using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Data_Mining
{
    class BaseInfo
    {
        public string FileName { get; set; }
        public List<string> ColumnList { get; set; }
        public string Destination { get; set; }

        public BaseInfo(Data data)
        {
            if (data != null)
            {
                FileName = data.FileName;
                Destination = data.Destination;
                ColumnList = data.ColumnNames;
            }
            else
            {
                MessageBox.Show("incorrect file!");

            }
        }   

    }
}
