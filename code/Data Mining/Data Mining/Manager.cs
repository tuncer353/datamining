using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Mining
{
    public class Results
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
        public double Std
        {
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

                Manager.register(nazwa, kolumna);

            }



            return wynik;


        }

        public static List<Results> Compare(List<String> paths)
        {
            List<Results> result = new List<Results>();
            List<double> column;
            String[] files;
            String colName;
            String filName;
            Data data;

            double max = 0;
            double min = 0;
            double avg = 0;
            double std = 0;

            foreach (String folder in paths)
            {
                files = System.IO.Directory.GetFiles(folder, "*.txt",System.IO.SearchOption.TopDirectoryOnly);

                foreach (String file in files)
                {
                    data = Data.CreateData(file);
                    filName = file.Split('\\').Last().ToString();
                    if (data == null)
                        continue;


                    for (int col = 0; col < data.ColumnNames.Count; col++)
                    {
                        column = new List<double>();
                        colName = filName + "_" + data.ColumnNames.ElementAt(col);


                        for (int i = 0; i < data.Records.Count; i++)
                            column.Add(data.Records[i].Entity[col]);

                        max = column.Max();
                        min = column.Min();

                        avg = column.Average();
                        std = getStandardDeviation(column);

                        result.Add(new Results(max, min, avg, std, file, colName));
                        Manager.register(file, colName);
                    }

                }
            }
            return result;
        }

        public static List<Results> Compare(String file)
        {
            List<Results> result = new List<Results>();
            List<double> column;
            String colName;
            String filName;
            Data data;

            double max = 0;
            double min = 0;
            double avg = 0;
            double std = 0;

            data = Data.CreateData(file);
            filName = file.Split('\\').Last().ToString();
            if (data == null)
                return null;


            for (int col = 0; col < data.ColumnNames.Count; col++)
            {
                column = new List<double>();
                colName = filName + "_" + data.ColumnNames.ElementAt(col);
                //colName = data.ColumnNames.ElementAt(col);

                for (int i = 0; i < data.Records.Count; i++)
                    column.Add(data.Records[i].Entity[col]);

                max = column.Max();
                min = column.Min();

                avg = column.Average();
                std = getStandardDeviation(column);

                result.Add(new Results(max, min, avg, std, file, colName));
                Manager.register(file, colName);
            }

            return result;
        }

        public static List<Results> Compare(List<ColumnSelector> lista, Boolean diff)
        {
            List<ColumnSelector> newList = new List<ColumnSelector>();
            List<Results> results;
            Results differences;
            String colName;
            double maxDiff = 0;
            double minDiff = 0;
            double avgDiff = 0;
            double stdDiff = 0;

            if (diff)
            {
                if (lista.Count >= 2)
                {
                    newList.Add(lista.ElementAt(0));
                    newList.Add(lista.ElementAt(1));

                    results = Manager.Compare(newList);
                    maxDiff = Math.Abs(results.ElementAt(0).Max - results.ElementAt(1).Max);
                    minDiff = Math.Abs(results.ElementAt(0).Min - results.ElementAt(1).Min);
                    avgDiff = Math.Abs(results.ElementAt(0).Avg - results.ElementAt(1).Avg);
                    stdDiff = Math.Abs(results.ElementAt(0).Std - results.ElementAt(1).Std);

                    colName = "|" + results.ElementAt(0).ColName + "-" + results.ElementAt(1).ColName + "|";
                    differences = new Results(maxDiff, minDiff, avgDiff, stdDiff, "Difference", colName);

                    results.Add(differences);
                    
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Must be selected at lest two columns!", "?!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return null;
                }

            }
            else
            {
                results = Manager.Compare(lista);
            }

            return results;
        }

        public static List<Results> Compare(List<String> paths, Boolean diff)
        {
            List<Results> results;

            if (diff)
            {
                System.Windows.Forms.MessageBox.Show("Sorry, this option is not aviable for Batch Processing.",
                    "?!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                results = null;
            }
            else
            {
                results = Manager.Compare(paths);
            }

            return results;
        }

        public static void batchProcessing(String[] args)
        {
            List<Results> results = new List<Results>();
            Object[] dataFormed;
            List<String> headers;
            List<String> paths;
            List<List<Object>> info;
            Boolean[] chosen = {true, true, true, true};

            if (args.Length < 4)
            {
                System.Console.WriteLine("Not enough arguments");
                return;
            }
            if (args[0] == "-mode")
            {
                if (args[1] == "sgl" )
                {
                    if (System.IO.File.Exists(args[2])){
                        results = Manager.Compare(args[2]);

                        dataFormed = Data.formatData(results, chosen);
                       
                        headers = (List<String>) dataFormed[0];
                        info = (List<List<Object>>) dataFormed[1];

                        Data.saveFile(args[3], headers, info);

                    }else{
                        System.Console.WriteLine("The file does not exist");
                    }

                }
                else if (args[ 1] == "bth")
                {
                    if (System.IO.Directory.Exists(args[2])) {

                        paths = new List<string>();
                        paths.Add(args[2]);
                        results = Manager.Compare(paths);

                        dataFormed = Data.formatData(results, chosen);

                        headers = (List<String>)dataFormed[0];
                        info = (List<List<Object>>)dataFormed[1];

                        Data.saveFile(args[3], headers, info);

                    }
                    else{
                        System.Console.WriteLine("The directory does not exist");
                    }

                }
                else
                {
                    System.Console.WriteLine("Processing mode not valid");
                }

                //Record.register(args[2], "ALL");

                System.Console.WriteLine("The process was successfully finished. Results saved in :");
                System.Console.WriteLine(" >>" + args[3]);


            }

        }

        public static void register(String Name, String col)
        {
            //String logFile = "C:\\Users\\Sokka\\Documents\\SE-Polonia\\Project\\datamining-gh-pages\\code\\Data Mining\\Data Mining\\bin\\Debug\\log.txt";
            String logFile = "log.txt";

            //System.IO.StreamWriter file = System.IO.File.AppendAll(logFile, line);
            String line = "\n" + Name + "\t" + col + "\t" + DateTime.Now.ToLongTimeString() + DateTime.Now.ToLongDateString();

            System.IO.File.AppendAllText(logFile, line);
            
            //file.WriteLine(line);
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
