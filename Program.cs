using System;
using System.Diagnostics;

namespace SortSpeedTest
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[100000000]; 

            Random rnd = new Random();

            //Заполняем массив рандомными числами:
            for (int i = 0; i < array.Length; i++) { array[i] = rnd.Next(0, 100000000); }

            //Bubble sort:

            Stopwatch sw = Stopwatch.StartNew(); 

            BubbleSort(array); 

            sw.Stop(); 

            Console.WriteLine("Bubble sort time: " + sw.ElapsedTicks + " ticks"); 

            //Quick sort:

            sw = Stopwatch.StartNew();

            QuickSort(array, 0, array.Length - 1);

            sw.Stop();

            Console.WriteLine("Quick sort time: " + sw.ElapsedTicks + " ticks");
            Console.ReadLine();
        }

        static void BubbleSort(int[] array) { /*...*/ }

        static void QuickSort(int[] arr, int left, int right) { /*...*/ }
        
        
    }
}