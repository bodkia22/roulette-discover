using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            //List<int>x = new List<int>();

            var rand = new Random();

            int count = 1;

            //List<int>Result = new List<int>();

            int result = 0;
            int length = 200;


            int X1=0;
            int X2=0;
            int X3=0;

            int indexEnd = 0;

            for (int i = 0; i <= length; i++)
            {
                X2 = rand.Next(1, 3);

                //x.Add(rand.Next(1,3));
                Console.WriteLine($"{i}it - {X1}");


                if (i == 0)
                {
                    X1 = X2;
                    continue;
                }

                if (X2 == X1)
                {
                    count++;
                }
                else
                {
                    X1 = X2;
                    //Result.Add(count);
                    if (count > result)
                    {
                        indexEnd= i;
                        result = count;
                    }
                    count = 1;
                }

                if (i == length)
                {
                    //Result.Add(count);
                    if (count > result)
                        result = count;
                }

                //if (x[i] == x[i - 1])
                //{
                //    count++;
                //}
                //else
                //{
                //    //Result.Add(count);
                //    if(count > result)
                //        result = count;
                //    count = 1;
                //}
                
                //if (i == length)
                //{
                //    //Result.Add(count);
                //    if (count > result)
                //        result = count;
                //}

            }

            Console.WriteLine("Max Count of the same: " + result);
            Console.WriteLine($"Index end of record at {indexEnd}");
            sw.Stop();

            Console.WriteLine("Total time:{0}",sw.Elapsed);
            //Console.WriteLine("Max Count of the same: " + Result.Max());
            //foreach (var res in Result)
            //{
            //    Console.WriteLine(" "+res);
            //}
        }
    }
}
