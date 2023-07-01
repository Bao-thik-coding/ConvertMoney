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
            int USD;
            Console.Write("Type in the USD to convert to VND: ");
            USD = int.Parse(Console.ReadLine());
            int VND  = USD * 23000;
            Console.WriteLine("USD convert to VND = " + VND);
            Console.ReadKey();
        }
    }
}
