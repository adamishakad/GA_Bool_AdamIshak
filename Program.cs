// Adam Ishak

using System.ComponentModel.Design;

namespace GA_Bool_AdamIshak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isSunny = true;
            bool isWarm = false;

            if(isSunny && isWarm)
            {
                Console.WriteLine("It's a sunny and warm day!");
            }else if(isSunny)
            {
                Console.WriteLine("It's sunny but not warm!");
            }else
            {
                Console.WriteLine("It is not sunny today");
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
}
