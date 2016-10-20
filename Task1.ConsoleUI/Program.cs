using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Task1.Logic;

namespace Task1.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                ShowMenu();
                string choiseText = Console.ReadLine();
                int choise;
                Int32.TryParse(choiseText, out choise);


                switch (choise)
                {
                    case 1:
                        FillFromFile();
                        break;
                    case 2:
                        FillWithRandom();
                        break;
                    case 0:
                        return;
                        
                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }
            }
        }

        private static void Searching(int[] array)
        {
            Console.WriteLine("What we will looking for?" + Environment.NewLine);
            string keyText = Console.ReadLine();
            int key;
            Int32.TryParse(keyText, out key);
            int? position = Search.BinarySearch(array, key);

            if (position != null)
            {
                Console.WriteLine("Position: {0}", position);
            }
            else
            {
                Console.WriteLine("Not found");
            }

            Console.ReadKey();
        }

        private static void FillWithRandom()
        {
            Console.WriteLine("How many numbers?" + Environment.NewLine);
            string sizeText = Console.ReadLine();
            int size;
            Int32.TryParse(sizeText, out size);
            if (size < 1)
            {
                Console.WriteLine("Array size can't be less than 1");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Max value of random number: ");
            string maxValueText = Console.ReadLine();
            int maxValue;
            Int32.TryParse(maxValueText, out maxValue);

            int[] array = new int[size];

            RandomFill.FillArray(array, maxValue);

            Array.Sort(array);

            ShowArray(array);

            Searching(array);
        }

        private static void FillFromFile()
        {
            Console.WriteLine("Enter path to file: ");
            string s = Console.ReadLine();
            int[] array = FileIO.ParseIntFromFile(s);

            Array.Sort(array);

            ShowArray(array);

            Searching(array);
        }

        private static void ShowArray(int[] array)
        {
            if (array == null)
                return;

            if (array.Length < 1)
                return;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}  ", array[i]);
            }

            Console.WriteLine();
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Binary search." +
                Environment.NewLine +
                "1. Fill array from file" +
                Environment.NewLine +
                "2. Fill array with random numbers" +
                Environment.NewLine + Environment.NewLine +
                "0. Exit" +
                Environment.NewLine + Environment.NewLine);
        }

    }
}
