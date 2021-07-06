using System;

namespace Car_Insurance_Basic_Approval_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, SpeedingTkt;
            string DUI;

            Console.WriteLine("Basic Approval Program for Car Insurance.");
            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            DUI = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            SpeedingTkt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");
            if (age > 15 && DUI == "False" && SpeedingTkt < 3)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
