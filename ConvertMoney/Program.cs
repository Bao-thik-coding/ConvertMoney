using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMoney
{
    class Program
    {
        static void Main(string[] args)
        {
            float vnd;
            Console.Write("Type in the VND to convert to USD: ");
            vnd = float.Parse(Console.ReadLine());
            float USD = vnd / 23000;
            Console.WriteLine("Vnd convert to Usd = " + USD);
            Console.ReadKey();
        }
    }
}
