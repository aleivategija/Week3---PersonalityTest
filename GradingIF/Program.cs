﻿using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma tulemus:");

            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userResult == 'A')
            {
                Console.WriteLine("Suurep2rane!");
            }
            else if (userResult == 'B')
            {
                Console.WriteLine("V2ga hea!");
            }
            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }
            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav");
            }
            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin");
            }
            else if (userResult == 'F')
            {
                Console.WriteLine("Puudulik");
            }
            else
                Console.WriteLine("Vale v22rtus");
                    
        }
    }
}
