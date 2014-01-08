using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Data_Mining
{
    class Data
    {
        private List<Record> records;
        private List<string> columnNames;
        private string fileName;
        private string destination;
        private int columns;
        private int rows;
        private static string temp = "";

        #region /-- properties --/

        public string Destination
        {
            get { return destination; }
        }
        public List<Record> Records
        {
            get { return records; }
            set { records = value; }
        }
        public List<string> ColumnNames
        {
            get { return columnNames; }
            set { columnNames = value; }
        }
        public string FileName
        {
            get { return fileName; }
        }
        public int Columns
        {
            get { return columns; }
        }
        public int Rows
        {
            get { return rows; }
        }

        #endregion

        #region /-- functions --/
        // --------------------------------------------------PRIVATE CONSTRUCTOR (to create an object use static function CreateData)
        private Data(string _destination, bool haveNames)
        {

            records = new List<Record>();

            destination = _destination;
            fileName = Path.GetFileName(@_destination);

            columnNames = new List<string>();
            string slowo = "";
            int count = 0;
            temp.Trim();
            int firstEnter = temp.IndexOf("\n");

            bool word = false;
            if (haveNames)
            {
                for (int i = 0; i <= firstEnter; i++)
                {



                    if ((temp[i] == ' ' && !word) || (temp[i] == '\n' && !word))
                        continue;
                    else if ((temp[i] == ' ' && word) || (temp[i] == '\n' && word)) // koniec pojedynczej danej
                    {

                        columnNames.Add(slowo);
                        count++;
                        word = false;
                        slowo = "";
                        continue;

                    }
                    word = true;
                    slowo += temp[i];

                }
                columns = count;
                temp = temp.Remove(0, firstEnter);
                temp.Trim();
            }
            else
            {
                word = false;
                for (int i = 0; i <= firstEnter; i++)
                {



                    if ((temp[i] == ' ' && !word) || (temp[i] == '\n' && !word))
                        continue;
                    else if ((temp[i] == ' ' && word) || (temp[i] == '\n' && word)) // koniec pojedynczej danej
                    {
                        count++;
                        word = false;
                        slowo = "";
                        continue;

                    }
                    word = true;
                    slowo += temp[i];

                }

                for (int i = 0; i < count; i++)
                    columnNames.Add(i.ToString());
                columns = count;
            }
            //-------------------------------------------------------------------koniec wypelniana tablicy nazw kolumn


            int endPos = 0, begPos = 0;
            endPos = temp.IndexOf("\n", endPos);
            if (endPos == 0)
                endPos = temp.IndexOf("\n", 1);
            int rowCount = 0;
            List<double> temporaryList = new List<double>();
            while (true)
            {
                if (endPos != -1 && endPos != temp.Length)
                {
                    word = false;
                    for (int i = begPos; i <= endPos; i++)
                    {



                        if ((temp[i] == ' ' && !word) || (temp[i] == '\n' && !word))
                            continue;
                        else if ((temp[i] == ' ' && word) || (temp[i] == '\n' && word)) // koniec pojedynczej danej
                        {
                            temporaryList.Add(Double.Parse(slowo));
                            //Console.WriteLine(slowo);
                            word = false;
                            slowo = "";
                            continue;

                        }
                        word = true;
                        slowo += temp[i];

                    }

                    Records.Add(new Record(temporaryList));

                    temporaryList.Clear();
                    rowCount++;
                    //Console.WriteLine(records.Count);
                    //Console.WriteLine(Records[0].Entity[0]);
                }
                else
                {
                    break;
                }
                begPos = endPos;
                try
                {
                    endPos = temp.IndexOf("\n", endPos + 1);
                }
                catch (Exception e)
                {
                    endPos = -1;
                }
            }
            rows = rowCount;

            temp = "";
        }




        //---------------------------------------------------STATIC FUNCTION before creating an object checks the extension, and data inside
        public static Data CreateData(string destination)
        {
            bool haveNames = false;
            if (Path.GetExtension(@destination) != ".txt")
            {
                MessageBox.Show("File " + Path.GetFileName(@destination) + " is not a .txt file!");
                return null;
            }

            try
            {
                using (StreamReader sr = new StreamReader(destination))
                {
                    temp = sr.ReadToEnd();

                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Cannot open file at:\n" + destination + "\n" + "exception: " + e.ToString());
                return null;
            }
            temp.Trim();
            int pos = 0;
            bool mamySlowo = false;
            string slowo = "";

            if (temp.Length == 0) // ----------------------- MAMY pusty plik
            {
                MessageBox.Show("File " + Path.GetFileName(@destination) + " is empty!");
                temp = "";
                return null;
            }

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == ' ' && !mamySlowo)
                    continue;
                else if (temp[i] == ' ' && mamySlowo)
                    break;

                mamySlowo = true;
                slowo += temp[i];


            }

            if (slowo == "") // ----------------------- MAMY pusty plik
            {
                MessageBox.Show("File " + Path.GetFileName(@destination) + " is empty!");
                temp = "";
                return null;
            }
            double result;

            int positionToCheck = 0;

            if (!Double.TryParse(slowo, out result))
            {
                haveNames = true;
                positionToCheck = temp.IndexOf("\n");
            }


            mamySlowo = false;
            slowo = "";


            for (int i = positionToCheck; i < temp.Length; i++)
            {
                if ((temp[i] == ' ' && !mamySlowo) || (temp[i] == '\n' && !mamySlowo))
                    continue;
                else if ((temp[i] == ' ' && mamySlowo) || (temp[i] == '\n' && mamySlowo) || ((i == temp.Length - 1) && mamySlowo))
                {
                    mamySlowo = false;
                    if (!Double.TryParse(slowo, out result))
                    {
                        MessageBox.Show("File " + Path.GetFileName(@destination) + " has wrong input data (cannot be parsed to double)");
                        temp = "";
                        return null;
                    }
                    slowo = "";
                    continue;
                }
                mamySlowo = true;
                slowo += temp[i];

            }

            return new Data(destination, haveNames);
        }
        #endregion





    }
}
