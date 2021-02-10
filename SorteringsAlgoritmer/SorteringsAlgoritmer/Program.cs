using System;
using System.Collections.Generic;
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

        static void Main(string[] args)
        {
            var tallista = new List<int>();
            tallista.Add(7); tallista.Add(10); tallista.Add(3); tallista.Add(1);
            tallista.Add(3); tallista.Add(15); tallista.Add(8); tallista.Add(5);

            Random slump = new Random();
            for (int i = 0; i < 60000; i++)
                tallista.Add(slump.Next(100000));

            BubbleSort(tallista);

            foreach (int i in tallista)
                Console.WriteLine(i);
        }
    }
}
