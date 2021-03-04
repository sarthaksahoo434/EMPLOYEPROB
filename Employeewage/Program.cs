using System;

namespace Employeewage
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs= 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
             if (empCheck == IS_FULL_TIME);
                empHrs = 8;
                empWage = empHrs * EMP_RATE_PER_HOUR;
             Console.WriteLine("*Emp wage :" + empWage);
            Console.ReadKey();
        }
    }
}
