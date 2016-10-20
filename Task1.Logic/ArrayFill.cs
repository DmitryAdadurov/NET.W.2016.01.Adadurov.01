using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1.Logic
{
    public class FileIO
    {
        public static int[] ParseIntFromFile(string path)
        {
            string[] intLines;

            try
            {
                intLines = File.ReadAllLines(path);
            }
            catch
            {
                throw new FileNotFoundException();
            }

            if (intLines.Length <= 0)
                return null;

            int[] values = new int[intLines.Length];

            for (int i = 0; i < intLines.Length; i++)
            {
                Int32.TryParse(intLines[i], out values[i]);
            }

            return values;
        }
    }

    public class RandomFill
    {
        public static void FillArray(int[] array, int maxRandomValue)
        {
            if (array == null)
                return;

            if (array.Length <= 0)
                return;

            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(maxRandomValue);
            }
        }
    }

}
