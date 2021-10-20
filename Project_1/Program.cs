// Release 1.01
// Copyright 2021 by Dominik Rolbiecki 
using System;
using System.Threading;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            // Funkcja estetyczno - rozrywkowa :)
            Intro();
            Console.WriteLine("Enter the upper range of the numbers to be searched");
            x = int.Parse(Console.ReadLine());
            bool[] tab = new bool[x + 1];
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Procesing");
            Thread.Sleep(1000);
            Console.Write('.');
            Thread.Sleep(1000);
            Console.Write('.');
            Thread.Sleep(1000);
            Console.Write('.');
            Console.ResetColor();
            Console.Clear();
            //Realizacja sita za pomocą tablic Bool'owskich 
            for (int i = 2; i * i <= x; i++)
            {
                if (tab[i] == true)
                {
                    continue;
                }
                for (int z = 2 * i; z <= x; z += i)
                {
                    tab[z] = true;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("The Results: ");
            Console.ResetColor();
            for (int i = 2; i <= x; i++)
            {
                if (tab[i] == false)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(700);
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        //Małe urozmaicenie estetyczne prostego zadania :)
        static void Intro()
        {
            Console.WriteLine("Hi Stranger, \n");
            Thread.Sleep(2000);
            Console.Write("Its my Prime Numbers Homework, so just ");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("SIT ");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("RELAX ");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("ENJOY :)");
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine("Press any key to proceed...");
            System.Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
        }
    }
}
