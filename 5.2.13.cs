using System;

namespace ConsoleApp7
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = GetArrayFromConsole(10);
            ShowArray(array, true);
            Console.WriteLine();

            Console.ReadKey();
        }

        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Enter array item № {0}", i);
                result[i] = Convert.ToInt32(Console.ReadLine());
            }
            return result;
        }

        static int[] SortArray(int[] result)
        {

            int temp;

            for (int k = 0; k < result.Length; k++)
            {
                for (int h = k + 1; h < result.Length; h++)
                {
                    if (result[k] > result[h])
                    {
                        temp = result[k];
                        result[k] = result[h];
                        result[h] = temp;
                    }
                }
            }

            return result;
        }

        static int[] ShowArray(int[] result, bool sign = false)
        {
            if (sign == true)
            {
                SortArray(result);
            }
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
            return result;
        }
    }
}