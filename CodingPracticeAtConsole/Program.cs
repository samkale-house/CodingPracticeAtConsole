using System;

namespace CodingPracticeAtConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get the Multiplication table:");
            GetMultiplicationTable();

            Console.WriteLine("Get the even numbers:");
            GetEvenNumber();

            Console.WriteLine("Get the odd numbers:");
            GetOddNumber();

            Console.WriteLine("Get the Prime numbers:");
            GetPrimeNumber();
        }
        static void GetMultiplicationTable()
        {
            int Num, Target;
            Console.WriteLine("Enter the Number to be multipled.");
            Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much multiples you need?");
            Target = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Table for " + Num + " upto " + Target + " multiples as below:");
            for(int i=1;i<=Target;i++)
            { Console.WriteLine(Num * i); }
        }
        static void GetEvenNumber()
        {
            int TargetNum;
            Console.WriteLine("Enter the target Number upto which you want even numbers.");
            TargetNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Even numbers upto " + TargetNum + " are below:");
            for(int i=0;i<=TargetNum;i++)
            { 
                if(i%2==0)
                { Console.WriteLine(i); }
            }
        }

        static void GetOddNumber()
        {
            int TargetNum;
            Console.WriteLine("Enter the target Number upto which you want odd numbers.");
            bool isValidNum = Int32.TryParse(Console.ReadLine(),out TargetNum);//use try parse and validate input
            if (isValidNum)
            {
                Console.WriteLine("Odd numbers upto " + TargetNum + " are below:");
                for (int i = 0; i <= TargetNum; i++)
                {
                    if (i % 2 != 0)
                    { Console.WriteLine(i); }
                }
            }
            else
                Console.WriteLine("Invalid User Input.Please enter a number.");
        }

        static void GetPrimeNumber()
        {
            int TargetNum;
            Console.WriteLine("Enter the target Number upto which you want prime numbers.");
            bool isValidNum = Int32.TryParse(Console.ReadLine(), out TargetNum);//use try parse and validate input
            if (isValidNum)
            {
                for (int i = 3; i <= TargetNum; i++)
                {
                    if (IsPrime(i))
                        Console.WriteLine(i);
                }
            }
            else
                Console.WriteLine("Invalid User Input.Please enter a number.");
        }

        static bool IsPrime(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
