using System;

namespace dataTypeConversion
{
    class Program
    {
        public struct MoneyConversion
        {
            public float gbp;
            public MoneyConversion(float r)
            {
                this.gbp = r;

            }
            public static explicit operator MoneyConversion(int usd)
            {
                float convertRate = 1.25f * usd;
         
                MoneyConversion temp = new MoneyConversion(convertRate);

                return temp;
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an amount from GBP which can be converted to USD");

            int mm = Convert.ToInt32(Console.ReadLine());

            MoneyConversion im = (MoneyConversion)mm;

            Console.WriteLine($"The conversion of {mm} is {im.gbp} in USD");

            Console.ReadKey();

        }
    }
}
 