using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fibonaccinums = new List<int> { 1, 1 };
            while(fibonaccinums.Count <20) {
                var num1 = fibonaccinums[fibonaccinums.Count - 1];
                var num2 = fibonaccinums[fibonaccinums.Count - 2];

                fibonaccinums.Add(num1 + num2);
            }
            foreach(var item in fibonaccinums)
            
                Console.WriteLine(item);
                Console.ReadKey();
            

        }
    }
}




