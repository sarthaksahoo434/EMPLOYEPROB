using System;

namespace UC6_Empwage
{
    class Program
    {
        static void Main(string[] args)
        {
            int Total_Working_hr = 100;
            int Total_Working_day = 20;
            int k;
            int wages = 0;
            
            for (k = 1; k <= Total_Working_hr; k++)

                wages = Total_Working_day * Total_Working_hr;
            Console.WriteLine("Total Working Wages For Month is = {0}", wages);

        }
    }
}
