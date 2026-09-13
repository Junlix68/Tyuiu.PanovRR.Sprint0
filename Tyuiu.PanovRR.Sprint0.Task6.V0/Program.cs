using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.PanovRR.Sprint0.Task6.V0.Lib;
namespace Tyuiu.PanovRR.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numArray));
            Console.WriteLine("Рахность элементов массива = " + DataService.SubtractionArray(numArray));
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(numArray));
            Console.ReadKey();
        }
    }
}
