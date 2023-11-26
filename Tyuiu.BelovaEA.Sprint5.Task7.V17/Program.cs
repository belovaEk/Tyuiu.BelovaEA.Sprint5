using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.BelovaEA.Sprint5.Task7.V17.Lib;
using System.IO;

namespace Tyuiu.BelovaEA.Sprint5.Task7.V17
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
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнила: Белова Екатерина Андреевна | ИИПб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* Дан файл,  в котором есть набор символьных данных.                      *");
            Console.WriteLine("* Удалить все удвоенные буквы 'нн' из файла.                              *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V17.txt.       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V17.txt";
            string path_out = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V17.txt";

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Данные находятся в файле: {path}");

            string res = ds.LoadDataAndSave(path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Находится в файле: {res}");

            Console.ReadKey();
        }
    }
}
