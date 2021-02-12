using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteringsAlgoritmer
{
    class Program
    {
        static void BubbleSort(List<int> minLista)
        {
            for (int i = 0; i < minLista.Count; i++)
            {
                for(int j = 0; j < minLista.Count-1; j++)
                {
                    if(minLista[j] > minLista[j+1])  //Om elementen ligger i fel ordning kollas här
                    {
                        //Byt plats på elementet på plats j med det på plats j+1
                        int temp = minLista[j];
                        minLista[j] = minLista[j + 1];
                        minLista[j + 1] = temp;
                    }
                }
            }
        }
        static void InsertionSort(List<int> minLista2)
        {
            //Gör en loop för varje tal som skall sorteras 
            //börja på index 1 då vi kommer att titta "bakåt" i vektorn
            for (int i = 1; i < minLista2.Length; i++)
            {
                //Stega bakåt från position i ned till 1 om så behövs
                for (int j = i; j > 0; j--)
                {
                    //jämför med talet "bakom" och se om det är större
                    if (minLista2[j] < minLista2[j - 1])
                    {
                        //byt plats på tal
                        int tmp = minLista2[j - 1];
                        minLista2[j - 1] = minLista2[j];
                        minLista2[j] = tmp;
                    }
                    //annars avsluta innerloop'en 
                    else
                        break;
                }
            }
        }



        static void Main(string[] args)
        {
            var tallista = new List<int>();

            Random slump = new Random();
            for (int i = 0; i < 100000; i++)
                tallista.Add(slump.Next(100000));

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            
            InsertionSort(tallista);

            stopWatch.Stop();
            Console.WriteLine("Listan är sorterad!");
            Console.WriteLine("Tid det tog: " + stopWatch.Elapsed);


        }
    }
}
