using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data_Mining
{
    struct Record
    {
        private List<double> entity;

        public List<double> Entity
        {
            get { return entity; }
            // set { entity = value; }
        }

        #region /-- konstruktory --/
        public Record(List<double> _record)
        {
            entity = new List<double>();
            foreach (double elem in _record)
                entity.Add(elem);
        }

        public Record(double[] _record)
        {
            entity = new List<double>();
            for (int i = 0; i < _record.Length; i++)
            {
                entity.Add(_record[i]);
            }
        }
        #endregion


    }
}



