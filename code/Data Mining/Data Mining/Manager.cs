using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Mining
{

    class Results
    {
        private double max;
        private double min;
        private double avg;
        private double std;
        private string name;
        private string colName;

        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public string ColName
        {
            get { return colName; }
            set { colName = value; }
        }
        public double Max
        {
            get { return max; }
            set { max = value; }
        }
        public double Min
        {
            get { return min; }
            set { min = value; }
        }

        public double Avg
        {
            get { return avg; }
            set { avg = value; }
        }
        public double Std {
            get { return std; }
            set { std = value; }
        }

        public Results(double _max, double _min, double _avg, double _std, string _name, string _colName)
        {
            max = _max;
            min = _min;
            avg = _avg;
            std = _std;
            name = _name;
            colName = _colName;
        }

    }

    static class Manager
    {

        #region /-- methods --/


        public static BaseInfo getBaseInfo(string path)
        {
            return new BaseInfo(Data.CreateData(path));
        } // ZWRACA obiekt base info (FileName, Destination, ColumnsList)

        private static double getStandardDeviation(List<double> doubleList)
        {
            double average = doubleList.Average();
            double sumOfDerivation = 0;
            foreach (double value in doubleList)
            {
                sumOfDerivation += (value) * (value);
            }
            double sumOfDerivationAverage = sumOfDerivation / doubleList.Count;
            return Math.Sqrt(sumOfDerivationAverage - (average * average));
        }

        public static List<Results> Compare(List<ColumnSelector> lista)
        {
            List<Results> wynik = new List<Results>();

            foreach (ColumnSelector elem in lista)
            {
                string nazwa = elem.getSelectedValues()[0];
                string kolumna = elem.getSelectedValues()[1];
                string sciezka = elem.getSelectedValues()[2];

                double max = 0;
                double min = 0;
                double avg = 0;
                double std = 0;

                Data dane = Data.CreateData(sciezka);
                if (dane == null)
                    continue;

                List<double> column = new List<double>();

                int pozycja = dane.ColumnNames.IndexOf(kolumna);

                if(pozycja == -1)
                    continue;

                for(int i = 0; i < dane.Records.Count ; i++)
                    column.Add(dane.Records[i].Entity[pozycja]);

                max = column.Max();
                min = column.Min();

                avg = column.Average();
                std = getStandardDeviation(column);

                wynik.Add(new Results(max, min, avg, std, nazwa, kolumna));

            }



            return wynik;


        }

        public static List<double> prepareColumn(string fileDestination, string selColumnName) //return null jesli problem z otwearciem pliku
        {
            Data dane = Data.CreateData(fileDestination);
            if (dane == null)
                return null;

            List<double> column = new List<double>();

            int pozycja = dane.ColumnNames.IndexOf(selColumnName);

            if (pozycja == -1)
                return null;

            for (int i = 0; i < dane.Records.Count; i++)
                column.Add(dane.Records[i].Entity[pozycja]);
            

            return column;
        }

        #endregion



    }
}
