using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for döngüsü
            //for(x;y;z)
            //x: başlangıç
            //y: bitiş
            //z: artış azalış

            //int i;
            //for (i = 1; i <=5; i++)
            //{
            //    Console.WriteLine("C# Egitim kampı");
            //}

            //for(int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}


            #endregion

            #region    for döngüsü ile karar yapıları
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //        Console.WriteLine(i);
            //}

            //int totalvalue = 0;
            //for (int i = 1; i <=10; i++) 
            //{ 
            //    totalvalue += i;
            //}
            //Console.WriteLine(totalvalue);


            //int totalValue = 0;
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for(int i=1; i <=50; i++)
            //{
            //    if (i % 7 == 0) 
            //    { 
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int bakteri = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bakteri *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bakteri);
            //}




            #endregion

            #region While döngüsü

            //while(şart)
            //{
            //islemler
            //}

            //int i = 19;
            //while (i >= 10) 
            //{
            //    Console.WriteLine("Merhaba Dünya");
            //    i--;
            //    Console.WriteLine(i);
            //}

            //int i = 1;
            //while (i < 13)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum +=i;
            //    i++;
            //}
            //Console.WriteLine(sum); 




            #endregion

            #region örn. sınav sorusu
            //Console.Write("SAYIYI GİRİNİZ= ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundred, thousands;
            //int sum;

            //ones = number%10;
            //Console.WriteLine("Birler basamağı" +ones);

            //tens = (number%100)/10;
            //Console.WriteLine("Onlar basamağı"+tens);

            //hundred = (number/100)%10;
            //Console.WriteLine("Yüzler basamağı"+hundred);

            //thousands = number/1000;
            //Console.WriteLine("Binler basamağı" + thousands);

            //sum = ones+tens+hundred+thousands;
            //Console.WriteLine("Rakamların toplamı"+sum);
            #endregion

            Console.Read();

        }
    }
}
