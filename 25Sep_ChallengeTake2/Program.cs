using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25SEP_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> super = new List<string>();
            super.Add("S");
            super.Add("U");
            super.Add("P");
            super.Add("E");
            super.Add("R");
            super.Add("C");
            super.Add("A");
            super.Add("L");
            super.Add("I");
            super.Add("F");
            super.Add("R");
            super.Add("A");
            super.Add("G");
            super.Add("I");
            super.Add("L");
            super.Add("I");
            super.Add("S");
            super.Add("T");
            super.Add("I");
            super.Add("C");
            super.Add("E");
            super.Add("X");
            super.Add("P");
            super.Add("I");
            super.Add("A");
            super.Add("L");
            super.Add("I");
            super.Add("D");
            super.Add("O");
            super.Add("C");
            super.Add("I");
            super.Add("O");
            super.Add("U");
            super.Add("S");
            foreach (string cali in super)
            {
                if (cali != "I")
                {
                    Console.WriteLine("Not an I.");
                }
                else
                {
                    Console.WriteLine(cali);
                }
            }
            Console.ReadKey();
        }
    }
}
