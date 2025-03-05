using System.Runtime.InteropServices;

namespace lab1_NP
{
    internal class Program
    {

        class FizzBuzz
        {
            private int i;

            public FizzBuzz(int i)
            {
                this.i = i;
            }

            public string Check()
            {
                if (i % 15 == 0)
                {
                    return "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    return "Fizz";
                }
                else if (i % 5 == 0)
                {
                    return "Buzz";
                }
                else
                    return i.ToString();
            }

           

        }

        static void Main(string[] args)
        {

            
            for (int i = 1; i <= 20; i++)
            {
                FizzBuzz fz = new FizzBuzz(i);
                Console.WriteLine(fz.Check());
            }  

            

        
        }
    }
}