using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.MaslennikovVA.Sprint1.Task3.V1.Lib;

namespace Tyuiu.MaslennikovVA.Sprint1.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Масленников В.А. | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Операторы составного присваивания                                       *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Масленников В.А. | ИИПб-24-2                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Объявите необходимые переменные и напишите программу вычисления объема  *");
            Console.WriteLine("* цилиндра,предполагающий ввод исходных данных.                           *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double h = 6;
            double r = 11;
            Console.WriteLine("Высота цилиндра = " + h);
            Console.WriteLine("Радиус цилиндра = " + r);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Объем цилиндра = " + ds.CylinderVolume(r, h));

            Console.ReadLine();

        }
    }
}
