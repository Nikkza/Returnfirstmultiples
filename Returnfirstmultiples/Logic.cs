using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnFirstMultiples
{
    public class Logic
    {
        public List<Tuple<int, double>> Parser(string yint, string xdouble)
        {
            var mylist = new List<Tuple<int, double>>();
            bool tryToParse;
            int intNumber = 0;
            double dNumber = 0;
            try
            {
                tryToParse = double.TryParse(xdouble, NumberStyles.Number, CultureInfo.GetCultureInfo("en-US"), out dNumber)
                    && Int32.TryParse(yint, out intNumber);
                if (tryToParse)
                    mylist.Add(Tuple.Create(intNumber, dNumber));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mylist;
        }

        public double[] Multiples(int m, double n)
        {
            double[] array = { };
            for (int i = 1; i <= m; i++)
                array = array.Concat(new double[] { n * i }).ToArray();
            return array;
        }
    }
}
