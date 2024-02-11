// Adam Ishak

using System.ComponentModel.Design;

namespace GA_Bool_AdamIshak
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Boolean variable
            bool isSunny = true;
            bool isWarm = false;
            
                // Conditional statements based on Boolean values

            if(isSunny && isWarm)
            {
                Console.WriteLine("It's a sunny and warm day!");
            }else if(isSunny)
            {
                Console.WriteLine("It's sunny but not warm!");
            }else
            {
                Console.WriteLine("It is not sunny today");

                // Using Boolean values in expressions
            }
            bool isWeekend = true;
            int dayOfWeek = 6;
            bool isRestDay = isWeekend || (dayOfWeek == 6);
            {
                Console.WriteLine("It's a rest day!");
            }
            
            {
                Console.WriteLine("It's a regular day.");
            }
            

        }
       
    }
