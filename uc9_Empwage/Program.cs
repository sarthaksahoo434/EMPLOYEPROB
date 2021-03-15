using System;

namespace uc9_Empwage
{
    
  
     
     
            public class EmpWageBuilder
        {
            public const int isPartTime = 1;
            public const int isFullTime = 2;

            private string company;
            private int salaryPerHr;
            private int noOfWorkingDays;
            private int maxHrsPerMonth;
            private int totalEmpWage;

            public EmpWageBuilder(string company, int salaryPerHr, int noOfWorkingDays, int maxHrsPerMonth)
            {
                this.company = company;
                this.salaryPerHr = salaryPerHr;
                this.noOfWorkingDays = noOfWorkingDays;
                this.maxHrsPerMonth = maxHrsPerMonth;
            }
            public void EmpWageUsingClassMethod()
            {
                int dailyHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
                while (totalEmpHrs <= this.maxHrsPerMonth && totalWorkingDays < this.noOfWorkingDays)
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
                    Console.WriteLine("Day#:" + totalWorkingDays + "Emp hrs :" + dailyHrs);
                }
                totalEmpWage = totalEmpHrs * this.salaryPerHr;
                Console.WriteLine("Total Employe wage for company :" + company + "is" + totalEmpWage);
            }
            public string toString()
            {
                return "total employee wage for company:" + this.company + "is" + this.totalEmpWage;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                EmpWageBuilder dMart = new EmpWageBuilder("Dmart", 20, 2, 10);
                EmpWageBuilder reliance = new EmpWageBuilder("Reliance", 10, 4, 20);
                dMart.EmpWageUsingClassMethod();
                Console.WriteLine(dMart.toString());
                reliance.EmpWageUsingClassMethod();
                Console.WriteLine(reliance.toString());
            }
        }
    }
