﻿using System;

namespace OrdinamentoVettori
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vettore = new int [10] { 1, 55, -9, 7, 74, 147, -87, 6, 0, 18};


            ordina(vettore);

            for (int i = 0; i < 10; i++)
                Console.WriteLine(vettore[i]);

            Console.ReadKey();
        }

        static void ordina (int[] vettore)
        {
            Array.Sort(vettore);
        }

     
    }
}
