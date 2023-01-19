using System;

namespace Mission2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            Console.WriteLine("Welcome to the dice throwing simulator!\n");
            Console.WriteLine("How many dice rolls would you like to simulate? ");
            // get the number of rolls
            int intRolls = Convert.ToInt32(Console.ReadLine());
            // create an array to hold values from 2-12 (possible combination rolled)
            int[] aCount = new int[11];

            for (int i = 0; i < intRolls; i++)
            {
                // calculate dice rolls
                int dice1 = r.Next(1,7);
                int dice2 = r.Next(1,7);
                int total = dice1 + dice2;

                // now put those results in the array
                if (total == 2)
                {
                    aCount[0]++;
                }
                if (total==3)
                {
                    aCount[1]++;
                }
                if (total == 4)
                {
                    aCount[2]++;
                }
                if (total == 5)
                {
                    aCount[3]++;
                }
                if (total == 6)
                {
                    aCount[4]++;
                }
                if (total == 7)
                {
                    aCount[5]++;
                }
                if (total == 8)
                {
                    aCount[6]++;
                }
                if (total == 9)
                {
                    aCount[7]++;
                }
                if (total == 10)
                {
                    aCount[8]++;
                }
                if (total == 11)
                {
                    aCount[9]++;
                }
                if (total == 12)
                {
                    aCount[10]++;
                }
            } // end for loop that rolls totals

            // print results
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + intRolls + "\n");
            
            // loop through the length of the count array to find each total asterisks
            for (int i = 0; i < aCount.Length; i++)
            { 
                int count = aCount[i] * 100;
                double cntAsterisks = (count / intRolls);
                Math.Round(cntAsterisks);
                Console.Write((i+2)  + ": ");

                // i am trying to continually concat on an asterisk for the value in the aCount[i]
                for (int ii = 0; ii < cntAsterisks; ii++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!\n");
        }
    }
}