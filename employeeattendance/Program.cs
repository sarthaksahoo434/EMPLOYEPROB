﻿using System;

namespace employeeattendance
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME =0;
            Random random = new Random();
            int empCheck = random.Next(0,2);
            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee is present");
            else
                Console.WriteLine("Employee is absent");
                Console.ReadKey();
            
        }
    }
}
