using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region void Metotlar

            //()
            //Geriye Değer Döndürmeyen Metotlar

            //Customer--> Listele, ekle, sil, güncelle
            //Void

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //CustomerList();
            //CustomerList();


            //void Sum()
            //{

            //            int x = 1;
            //            int y = 2;

            //            int z = x + y;
            //            Console.WriteLine(z);

            //}

            //Sum();




            #endregion

            #region geriye değer döndürmeyen parametreli metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Volkan Demirel");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");

            #endregion

            #region geriye değer döndürmeyen int parametleri metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);


            #endregion

            #region geriye değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Yusuf";
            //    string surname = "En Nesyri";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());


            #endregion

            #region geriye değer döndüren string parametreli metotlar

            //string CountryCard(string countryName,string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: "+ countryName+ " -  Başkent: "+ capital + " - Bayrak Rengi: "+ flagColor;
            //    return cardInfo;
            //}
            //Console.Write("Ülke Adını giriniz: ");
            //string x =Console.ReadLine();

            //Console.Write("Başkent giriniz: ");
            //string y = Console.ReadLine();

            //Console.Write("Bayrak rengini giriniz: ");
            //string z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));






            #endregion

            #region geriye değer döndüren int parametreli metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));

            #endregion

            #region örnek uyg


            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student +" isimli Öğrenci sınavı geçti/"+" ortalaması: "+result;
            //    }
            //    else
            //    {
            //        return student + " isimli Öğrenci başarısız oldu/"+" ortalaması: " + result;
            //    }

            //}

            //Console.WriteLine(ExamResult("Ali", 40, 23, 35));
            //Console.WriteLine(ExamResult("Kerim",86, 55, 35));

            #endregion


            Console.Read();
        }
    }
}

