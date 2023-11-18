using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Test.Review.ShakirovRR.Sprint3.Lib;

namespace Test.Review.ShakirovRR.Sprint3.Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #3 | Выполнил: Шакиров Р. Р. | ИСТНБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Базовые навки работы в C#                                         *");
            Console.WriteLine("* Задание SprintReview                                                    *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Шакиров Рамиль Русланович | ИСТНБ-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит на экран результат                  *");
            Console.WriteLine("* данного нам задания                                                     *");
            Console.WriteLine("*            2x - 3                                                       *");
            Console.WriteLine("* F(x) =  ------------  + 5x - sin(x)                                     *");
            Console.WriteLine("*          cos(x) - 2x                                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("* старт шага: " + startValue);
            Console.WriteLine("* конец шага: " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;
            double[] valueArray;
            valueArray = new double[len];
            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+-----------+-----------+");
            Console.WriteLine("|    X      |    f(x)   |");
            Console.WriteLine("+-----------+-----------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}      |  {1,6:f2}  |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+-----------+-----------+");
            Console.ReadLine();
        }
    }
}
