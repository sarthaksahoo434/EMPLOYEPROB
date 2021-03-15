using System;

namespace uc5_empwage
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is_Full_Time = 1;
            int Is_Part_Time = 2;
            int salaryPerHr = 20;
            int salary;
            int dailyHr = 0;
            Random random = new Random();
            int Checkval = random.Next(0, 3);
            switch (Checkval)
            {
                case 1:
                    dailyHr = 8;
                    Console.WriteLine("Employee is Full Time Present:");
                    salary = dailyHr * salaryPerHr;
                    Console.WriteLine("Salary of employee is:", +salary);
                    break;
                case 2:
                    dailyHr = 4;
                    Console.WriteLine("Employee is Part Time Present:");
                    salary = dailyHr * salaryPerHr;
                    Console.WriteLine("Salary of employee is:", +salary);
                    break;
            }
        }
    }
}
