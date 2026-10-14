using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{

    internal class Program
    {
        //1
        public static int[] MakeArray(Random random, int arsize, int min, int max)
        {
            int[] array = new int[arsize];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(min, max);
            }

            return array;
        }
        //2
        public static void PrintArray(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] massive = MakeArray(random, 100, 100, 900);
            PrintArray(massive);
            //a
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] > 500)
                {
                    Console.Write(massive[i] + " ");
                }
            }
            //b
            Console.WriteLine();

            int sum = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                sum += massive[i];
            }
            Console.WriteLine("скма: " + sum);
            //e
            Console.WriteLine();

            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] % 5 == 0)
                {
                    Console.Write(massive[i] + " ");
                }
            }
            //f 
            Console.WriteLine();

            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] % 2 == 0)
                {
                    Console.Write(massive[i] + " ");
                }
            }
            //g
            Console.WriteLine();

            int min = massive[0];
            int max = massive[0];

            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] < min)
                {
                    min = massive[i];
                }

                if (massive[i] > max)
                {
                    max = massive[i];
                }
            }

            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            //h
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] >= 500 && massive[i] <= 600)
                {
                    count++;
                }
            }
            Console.WriteLine("Count: " + count);
            //i
            Console.WriteLine();

            bool found = false;
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] == 899)
                {
                    found = true;
                }
            }

            if (found)
            {
                Console.WriteLine("Число 899 є в масивi");
            }
            else
            {
                Console.WriteLine("Числа 899 немає в масивi");
            }
            //j
            Console.WriteLine();

            int sumRange = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] >= 100 && massive[i] <= 200)
                {
                    sumRange += massive[i];
                }
            }
            Console.WriteLine("Sum 100-200: " + sumRange);
            //k
            Console.WriteLine();

            int max1 = massive[0];
            int max2 = massive[0];

            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] > max1)
                {
                    max2 = max1;
                    max1 = massive[i];
                }
                else if (massive[i] > max2 && massive[i] != max1)
                {
                    max2 = massive[i];
                }
            }
            Console.WriteLine("Second max: " + max2);
            //L
            Console.WriteLine();

            for (int i = 0; i < massive.Length; i++)
            {
                string s = massive[i].ToString();

                if (s.Contains("7"))
                {
                    Console.Write(massive[i] + " ");
                }
            }











        }
    }
    }
}
