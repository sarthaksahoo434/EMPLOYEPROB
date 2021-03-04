using System;

namespace UC3_Onwards
{
    class Program
    {
        static void Main(string[] args)
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            if (empcheck == IS_PART_TIME)
                empHrs = 4;
            else if(empcheck == IS_FULL_TIME)
                empHrs = 8;
            empwage = empHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine(" Emp Wage:" + empwage);
            Console.ReadKey();
        }
    }
}
