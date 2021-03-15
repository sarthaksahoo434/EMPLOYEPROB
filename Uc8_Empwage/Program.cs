using System;

namespace Uc8_Empwage
{
 
    class Program
    {
        public const int isPartTime = 1;
        public const int isFullTime = 2;

        public static int EmpWageUsingClassMethod(string company, int salaryPerHr, int noOfWorkingDays, int maxHrsPerMonth)
        {
            int dailyHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= maxHrsPerMonth && totalWorkingDays < noOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int checkVal = random.Next(0, 3);
                switch (checkVal)
                {
                    case isPartTime:
                        dailyHrs = 4;
                        break;
                    case isFullTime:
                        dailyHrs = 8;
                        break;
                }
                totalEmpHrs += dailyHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "employee hours:" + dailyHrs);
            }
            int totalEmpWage = totalEmpHrs * salaryPerHr;
            Console.WriteLine("Total employee wage for company:" + company + "is:" + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            EmpWageUsingClassMethod("Dmart", 20, 2, 10);
            EmpWageUsingClassMethod("Reliance", 10, 4, 20);
        }
    }
}