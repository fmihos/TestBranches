﻿using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 0;
            var max = args.Length != 0 ? Convert.ToInt32(args[0]) : -1;
            while (max == -1 || counter < max)
            {
                counter++;
                Console.WriteLine($"Counter (value): {counter}");
                System.Threading.Tasks.Task.Delay(3000).Wait();
            }
        }
    }
}
