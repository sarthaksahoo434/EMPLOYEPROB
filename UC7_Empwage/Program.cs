using System;

namespace UC7_Empwage
{
    class Program
    {
        static void Main(string[] args)
        { }
         public const int isPartTime = 1;
        public const int isFullTime = 2;
        public const int salaryPerHr = 20;
        public const int noOfWorkingDays = 2;
        public static int maxHrInMonth = 10;
        public static int EmpWageUsingClassMethod()
        {
            int dailyHrs = 0, totalDailyHrs = 0, totalWorkingDays = 0;
            while (totalDailyHrs <= maxHrInMonth && totalWorkingDays < noOfWorkingDays)
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
                totalDailyHrs += dailyHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "Employee hours:" + dailyHrs);
            }
            int totalDailyWage = totalDailyHrs * salaryPerHr;
            Console.WriteLine("total employee wage:" + totalDailyWage);
            return totalDailyWage;
        }
      
        }
    }

