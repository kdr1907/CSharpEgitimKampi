using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel dizi örnek
            //string[] colors = new string[4];
            //colors[0] = "Sarı";
            //colors[1] = "Lacivert";
            //colors[2] = "Beyaz";
            //colors[3] = "Yeşil";
            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Madrid";
            //cities[2] = "İstanbul";
            //cities[3] = "Paris";
            //cities[4] = "Delhi";
            //Console.WriteLine(cities[5]); //hata

            //int[] numbers = new int[10];
            //numbers[0] = 1;            
            //numbers[2] = 3;
            //numbers[4] = 5;
            //numbers[7] = 6;
            //Console.WriteLine(numbers[3]); //default değer 0

            //int[] numbers = new int[] { 50, 45, 553, 533, 2356, 75, 135, 214 };
            //Console.WriteLine(numbers[2]);





            #endregion

            #region dizideki tüm elemanları listeleme
            //string[] fenerbahce = { "İrfan Can", "Edin Dzeko", "Dusan Tadic", "En nesyri" };
            //for (int i = 0; i < fenerbahce.Length; i++)
            //{
            //    Console.WriteLine(fenerbahce[i]);
            //}

            /*int[] number = { 4,85,96,75,125,635,488,52,7456,2365,1120};
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] % 3 == 0)
                {
                    Console.WriteLine(number[i]);
                }

            }
            */

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);




            //string[] persons = { "Ali", "Oguzhan", "Enes", "Yusuf", "Ferhude", "Utum Su", "SŞ" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 45, 85, 52, 41, 10, 22, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 45, 85, 52, 41, 10, 22, 35 };
            //Array.Reverse(numbers); //diziyi tersten sıralıyor
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region dizi metotları

            //string[] customers = { "Ali", "Buse", "Deli", "Çetin", "Kertenkele", "Toreyra", "Dijiku" };
            //int index = Array.IndexOf(customers, "Dijiku");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + " Dizinin En Küçük Elemanı: " + numbers.Min());



















            #endregion

            #region KULLANICIDAN Değer alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("---------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //    for(int i=0; i<numbers.Length; i++) 
            //{ sum += numbers[i]; }
            //    Console.WriteLine(sum);

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}





            #endregion



            Console.Read();
        }
    }
}
