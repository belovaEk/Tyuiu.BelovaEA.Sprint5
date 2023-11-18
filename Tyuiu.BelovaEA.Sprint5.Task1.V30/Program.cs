using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BelovaEA.Sprint5.Task1.V30.Lib;

namespace Tyuiu.BelovaEA.Sprint5.Task1.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнила: Белова Е. А. | ИИПб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнила: Белова Екатерина Андреевна | ИИПб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Дана функция, F(x) = cos(x) + sin(x)/(2-2x) - 4x                        *");
            Console.WriteLine("* Произвести табулирование f(x) на диапазоне [-5;5] с шагом 1.            *");
            Console.WriteLine("* При делении на ноль вернуть значение 0.                                 *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask1.txt                *");
            Console.WriteLine("* и вывести на консоль значения (таблицу).                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            int start = -5;
            int stop = 5;

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Диапазон: [-5;5]");

            string res = ds.SaveToFileTextData(start, stop);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Файл: {res}\nСоздан!");

            double rez;

            for (int x = start; x <= stop; x++)
            {
                if (x == 1)
                {
                    rez = 0;
                }
                else
                {
                    rez = Math.Round((Math.Cos(x) + Math.Sin(x) / (2 - 2 * x) - 4 * x), 2);
                }
                Console.WriteLine(rez);
            }
                Console.ReadKey();
        }
    }
}
