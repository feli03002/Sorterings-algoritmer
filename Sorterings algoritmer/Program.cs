using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sorterings_algoritmer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tallista = new List<int>();
            List<string> data = new List<string>();
            Stopwatch stopwatch = new Stopwatch();
            int mängd = 1;
            int försök = 1;
            int medel = 0;
            try
            {
                 mängd = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException) { }

            try
            {
                 försök = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException) { }
            

            data.Add("Bs");
            Console.WriteLine("Sorteringsalgoritm: Bubblesort");
            for(int i = 0; i < mängd; i++)
            {
                
                int ant = Convert.ToInt32(1000 * Math.Pow(2, i));
                data.Add(Convert.ToString(ant));
                for (int j = 0; j < försök; j++)
                {
                    SkapaLista(tallista, ant);
                    stopwatch.Reset();
                    stopwatch.Start();
                    //Algoritmer.Bubblesort(tallista);
                    stopwatch.Stop();
                    Console.WriteLine("Längd på lista: " + ant + " Tid i millisekunder: " + stopwatch.ElapsedMilliseconds);
                    data.Add(" " + stopwatch.ElapsedMilliseconds + "ms");
                    medel += Convert.ToInt32(stopwatch.ElapsedMilliseconds);
                    stopwatch.Reset();
                    tallista.Clear();
                }
                medel /= försök;
                data.Add(" Medel: " + medel + "ms");
                medel = 0;
            }


            Console.WriteLine();

            Console.WriteLine("Sorteringsalgoritm: Selectsort");
            data.Add("Ss");
            for (int i = 0; i < mängd; i++)
            {
                int ant = Convert.ToInt32(1000 * Math.Pow(2, i));
                data.Add(Convert.ToString(ant));
                for (int j = 0; j < försök; j++)
                {
                    SkapaLista(tallista, ant);
                    stopwatch.Reset();
                    stopwatch.Start();
                   // Algoritmer.Selectionsort(tallista);
                    stopwatch.Stop();
                    Console.WriteLine("Längd på lista: " + ant + " Tid i millisekunder: " + stopwatch.ElapsedMilliseconds);
                    data.Add(" " + stopwatch.ElapsedMilliseconds + "ms");
                    medel += Convert.ToInt32(stopwatch.ElapsedMilliseconds);
                    stopwatch.Reset();
                    tallista.Clear();
                }
                medel /= försök;
                data.Add(" Medel: " + medel + "ms");
                medel = 0;
            }

            Console.WriteLine();

            Console.WriteLine("Sorteringsalgoritm: Mergesort");
            data.Add("Ms");
            for (int i = 0; i < mängd; i++)
            {
                int ant = Convert.ToInt32(1000 * Math.Pow(2, i));
                data.Add(Convert.ToString(ant));
                for (int j = 0; j < försök; j++)
                {
                    SkapaLista(tallista, ant);
                    stopwatch.Reset();
                    stopwatch.Start();
                   // Algoritmer.Mergesort(tallista);
                    stopwatch.Stop();
                    Console.WriteLine("Längd på lista: " + ant + " Tid i millisekunder: " + stopwatch.ElapsedMilliseconds);
                    data.Add(" " + stopwatch.ElapsedMilliseconds + "ms");
                    medel += Convert.ToInt32(stopwatch.ElapsedMilliseconds);
                    stopwatch.Reset();
                    tallista.Clear();
                }
                medel /= försök;
                data.Add(" Medel: " + medel + "ms");
                medel = 0;
            }
            Console.WriteLine();

            Console.WriteLine("Sorteringsalgoritm: Quicksort");
            data.Add("Qs");
            for (int i = 0; i < mängd; i++)
            {
                int ant = Convert.ToInt32(1000 * Math.Pow(2, i));
                data.Add(Convert.ToString(ant));
                for (int j = 0; j < försök; j++)
                {
                    SkapaLista(tallista, ant);
                    stopwatch.Reset();
                    stopwatch.Start();
                    Algoritmer.Quicksort(tallista, 0, tallista.Count - 1);
                    stopwatch.Stop();
                    Console.WriteLine("Längd på lista: " + ant + " Tid i millisekunder: " + stopwatch.ElapsedMilliseconds);
                    data.Add(" " + stopwatch.ElapsedMilliseconds + "ms");
                    medel += Convert.ToInt32(stopwatch.ElapsedMilliseconds);
                    stopwatch.Reset();
                    tallista.Clear();
                }
                medel /= försök;
                data.Add(" Medel: " + medel + "ms");
                medel = 0;
            }
            System.IO.File.WriteAllLines("..\\..\\Data.txt", data);
            Console.Write("Press to Exit");
            Console.ReadLine();
        }
       

        static void SkapaLista(List<int> list, int ant)
        {
            Random r = new Random();

            for(int i = 0; i < ant; i++)
            {
                list.Add(r.Next(10000));
            }
        }
       
        
    }
}
