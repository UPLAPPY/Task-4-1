using inf_to_2024._02._02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace inf_to_2024._02._02
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("1 - одномерные массивы");
            Console.WriteLine("2 - Двумерные массивы");
            Console.WriteLine("3 - Ступенчатые массивы");
            Console.WriteLine("Выберите с какими массивами вы хотите работать:");
            int choice;
            string com;
            choice = Convert.ToInt32(Console.ReadLine());
            bool input_ch;
            if (choice == 1)
            {
                Console.WriteLine("Введите true, если хотите заполнить массив автоматически");
                Console.WriteLine("Введите false, если хотите заполнить массив самостоятельно");
                input_ch = Convert.ToBoolean(Console.ReadLine());
                Array1 arr = new Array1(input_ch);
                Console.WriteLine("Список команд: Show - вывести исходный массив");
                Console.WriteLine("Average - найти и вывести среднее значение в массиве");
                Console.WriteLine("Delete - удалить все элементы, бльшие 100 по модулю");
                Console.WriteLine("DeleteRepeat - удалить все повторяющиеся элементы");
                Console.WriteLine("Stop - остановить выполнение программы");
                com = Console.ReadLine();
                while (com != "Stop")
                {
                    if (com == "Show")
                    {
                        arr.PrintArray();
                    }
                    else if (com == "Average")
                    {
                        arr.Average();
                    }
                    else if (com == "Delete")
                    {
                        arr.DeleteMore100();
                    }
                    else if (com == "DeleteRepeat")
                    {
                        arr.DeletePovtor();
                    }
                    else if (com == "Stop")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Команда не распознана");
                    }
                    Console.WriteLine("Введите команду:");
                    com = Console.ReadLine();
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Введите количество строк и столбцов массива, \n" +
                    "Каждое значение с новой строки:");
                int stroki, stolbiki;
                stroki = Convert.ToInt32(Console.ReadLine());
                stolbiki = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите true, если хотите заполнить массив автоматически");
                Console.WriteLine("Введите false, если хотите заполнить массив самостоятельно");
                input_ch = Convert.ToBoolean(Console.ReadLine());
                Array2 arr = new Array2(stroki, stolbiki, input_ch);
                Console.WriteLine("Список команд: \n" +
                    "Average - найти и вывести среднее значение массива \n" +
                    "Output - вывести существующую матрицу, \n " +
                    "       а затем её же, печатая элементы четных строк в обратном порядке \n" +
                    "Stop - остановить выполнение программы");
                com = Console.ReadLine();
                while (com != "Stop")
                {
                    if (com == "Average")
                    {
                        arr.Average();
                    }
                    else if (com == "Output")
                    {
                        arr.ArrayOutput();
                        arr.ChangedArrayOutput();
                    }
                    else if (com == "Stop")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Команда не распознана, попробуйте еще раз");
                    }
                    Console.WriteLine("Введите команду:");
                    com = Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Введите количество подмассивов массива:");
                int stroki = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите true, если хотите заполнить массив автоматически");
                Console.WriteLine("Введите false, если хотите заполнить массив самостоятельно");
                input_ch = Convert.ToBoolean(Console.ReadLine());
                Array3 arr = new Array3(stroki, input_ch);
                Console.WriteLine("Список команд: \n" +
                    "Show - вывести исходный массив \n" +
                    "Average - найти среднее значение во всем массиве \n" +
                    "Average_Each - найти средние значения во всех вложенных массивах \n" +
                    "ChangedArray - заменить все четные по значению элементы массива на произведения их индексов");
                com = Console.ReadLine();
                while (com != "Stop")
                {
                    if (com == "Show")
                    {
                        arr.ArrayOutput();
                    }
                    if (com == "Average")
                    {
                        arr.BigAverage();
                    }
                    else if (com == "Average_Each")
                    {
                        arr.SmallAverage();
                    }
                    else if (com == "ChangedArray")
                    {
                        arr.ChangeChetToPr();
                    }
                    else if (com == "Stop")
                    {
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Команда не распознана, попробуйте еще раз");
                    }
                    Console.WriteLine("Введите команду:");
                    com = Console.ReadLine();
                }
            }
        }
    }
}