﻿using System;

namespace ForLoopSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada kolm numbrit
            //programm kuvab nende numbrite summat

            int sum = 0;

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("sisesta number:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                sum = sum + userNumber;
            }

            Console.WriteLine($"your total is: {sum}");
        }
    }
}
