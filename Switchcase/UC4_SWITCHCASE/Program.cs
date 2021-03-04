using System;

namespace UC4_SWITCHCASE
{
    class Program
    {
        static void Main(string[] args)
        {
            const int IS_PART_TIME = 1;
            const  int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            
            int empHrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            switch (empcheck)
            {
                    case IS_PART_TIME:
                    empHrs = 4;
                    break;
                    case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empwage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine(" Emp Wage:" + empwage);
            Console.ReadKey();
        }
    }
}
