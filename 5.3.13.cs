using System;

namespace ConsoleApp7
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num = 2;
            int[] array = GetArrayFromConsole(ref num);
            int[] sorted_asc;
            int[] sorted_desc;

            SortArray(in array, out sorted_asc, out sorted_desc);

            foreach (int item_asc in sorted_asc)
            {
                Console.WriteLine(item_asc);
            }
            Console.WriteLine();

            foreach (int item_desc in sorted_desc)
            {
                Console.WriteLine(item_desc);
            }
            Console.ReadKey();
        }

        static int[] GetArrayFromConsole(ref int num)
        {
            num = 6;
            var result = new int[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Enter array item № {0}", i);
                result[i] = Convert.ToInt32(Console.ReadLine());
            }
            return result;
        }

        static int[] SortArrayAsc(int[] result)
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

        static int[] SortArrayDesc(int[] result)
        {
            int temp;

            for (int k = 0; k < result.Length; k++)
            {
                for (int h = k + 1; h < result.Length; h++)
                {
                    if (result[k] < result[h])
                    {
                        temp = result[k];
                        result[k] = result[h];
                        result[h] = temp;
                    }
                }
            }

            return result;
        }

        static void SortArray(in int[] result, out int[] sorted_asc, out int[] sorted_desc)
        {
            sorted_asc = SortArrayAsc(result);
            sorted_desc = SortArrayDesc(result);
        }
    }
}