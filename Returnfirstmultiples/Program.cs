using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnFirstMultiples
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic _logic = new Logic();
            string yInt = string.Empty;
            string xDouble = string.Empty;
            while (true)
            {
                yInt = Console.ReadLine();
                xDouble = Console.ReadLine();
                var list = _logic.Parser(yInt, xDouble);
                var results = _logic.Multiples(list[0].Item1, list[0].Item2);
                Console.WriteLine($"Multiples: {string.Join(",", results)}");
                Console.WriteLine("-----------------");

            }
        }
    }
}
