using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DuplicacyInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0,
                1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 2, 3, 14, 5, 6, 7, 8, 9, 0 };

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            UsingHashTables(intArray);
            var hashTime = stopwatch.Elapsed.TotalSeconds;
            stopwatch.Reset();
            Console.WriteLine($"Time Elapsed using HashTables (in seconds) : {hashTime}");
            Console.WriteLine("-------------------------------------------------------");
            stopwatch.Start();
            UsingDictionary(intArray);
            var dictTime = stopwatch.Elapsed.TotalSeconds;
            stopwatch.Stop();
            Console.WriteLine($"Time Elapsed using Dictionary (in seconds) : {dictTime}");
            Console.WriteLine("-------------------------------------------------------");
            Console.ReadLine();
        }

        private static void UsingDictionary(int[] intArray)
        {
            Dictionary<int, int> pairList = new Dictionary<int, int>();
            foreach (var item in intArray)
            {
                if (pairList.Select(k=>k.Key == item) == null )
                {
                    pairList.Add(item, 1);
                }
                else
                {
                    pairList[item] = pairList.FirstOrDefault(k => k.Key == item).Value + 1;
                }
            }
            //foreach (var item in pairList)
            //{
            //    Console.WriteLine($"Array Key and Count -  {item.Key} : {item.Value} ");
            //}
        }

        private static void UsingHashTables(int[] intArray)
        {
            Hashtable arrayCount = new Hashtable();
            foreach (var item in intArray)
            {
                if (!arrayCount.ContainsKey(item))
                {
                    arrayCount.Add(item, 1);
                }
                else
                {
                    arrayCount[item] = int.Parse(arrayCount[item].ToString()) + 1;
                }
            }
            //foreach (DictionaryEntry item in arrayCount)
            //{
            //    Console.WriteLine($"Array Key and Count -  {item.Key} : {item.Value} ");
            //}
        }
    }
}
