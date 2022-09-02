namespace D1
{
    internal class MathCase
    {
        // case 1: input bilangan 3 digit lalu konversi ke dollar
        // input : 75000, output = Rp50=10, Rp10=0, Rp5=1
        public static void ATM()
        {
            int digit1, digit2, digit3, sisa;
            Console.Write("Enter money: ");
            int number = Convert.ToInt32(Console.ReadLine());
            digit1 = number / 50_000;
            sisa = number % 50_000;

            digit2 = sisa / 10_000;
            sisa %= 10_000;

            digit3 = sisa / 5_000;
            sisa %= 5_000;

            Console.WriteLine($"Rp50ribu={digit1} Rp10ribu={digit2} Rp 5ribu={digit3} sisa={sisa}");
        }

        // input bilangan : 2345 atau 9999
        // output : 2+3+4+5 = 14 atau 36
        public static void SumDigit()
        {
            int digit1, digit2, digit3, r;
            Console.Write("Enter 4 digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            digit1 = number / 1000;
            r = number % 1000;

            digit2 = r / 100;
            r %= 100;

            digit3 = r / 10;
            r %= 10;

            /*int sum = digit1+digit2+digit3+r;
            Console.WriteLine($"Total Sum : " + sum);*/ //input = 2345 output = 14

            string reverse = r + "" + digit3 + "" + digit2 + "" + digit1;
            Console.WriteLine($"reverse : {reverse}"); //input = 2345 output = 5432
            Console.WriteLine($"reverse : {r}{digit3}{digit2}{digit1}");


        }
        // Kelipatan 3 dan 5 output FizzBuzz
        // Kelipatan 3 output Fizz
        // Keliapatan 5 output Buzz
        public static void FizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
        // prime number
        public static bool isPrime(int n)
        {
            for (int i = 2; i <= n/2; i++)
            {
                if(n%i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}