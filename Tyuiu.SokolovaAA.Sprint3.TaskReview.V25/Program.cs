using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SokolovaAA.Sprint3.TaskReview.V25.Lib;
namespace Tyuiu.SokolovaAA.Sprint3.TaskReview.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага =  " + stopValue);
            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);


            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("+-------------+-------------+");
            Console.WriteLine("|      X      |     f(x)    |");
            Console.WriteLine("+-------------+-------------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("| {0,6:d}      |   {1,6:f2}    |", startValue, valueArray[i]);
                startValue++;
            }

            Console.WriteLine("+-------------+-------------+");
            Console.ReadKey();

            
        }
    }
}
