﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region alt alta 10 tane yıldız


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");

            //}

            #endregion

            #region yan yana 10 tane yıldız


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");

            //}

            #endregion

            #region alt alta 10 tane yıldız her satırda 10 tane yıldız


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("********");

            //}

            #endregion

            #region dik üçgen

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    { 
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region ters dik üçgen

            //for (int i = 5; i >=1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region elmas ters ve dik üçgen 

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int k = 4; k >= 1; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region baklava dilimi

            //int n = 5;

            //// Üst kısım (piramit)
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j > 0; j--) // Azalan boşluklar
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++) // Yıldızları bas
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// Alt kısım (ters piramit)
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    for (int j = n - i; j > 0; j--) // Artan boşluklar
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i - 1; k++) // Yıldızları bas
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region piramit
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    //boşluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region ters piramit

            //int n = 5;
            //for (int i = n; i >= 1; i--)
            //{
            //    //boşluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion





            Console.Read();

        }
    }
}
