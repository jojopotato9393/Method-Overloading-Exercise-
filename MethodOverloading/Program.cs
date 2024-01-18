using System.Diagnostics.CodeAnalysis;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Add(1, 3);
            // Add(2.3, 2.3);
         
            string result = Add(1, 4, true);
            Console.WriteLine(result);
        }

        public static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public static void Add(double num1, double num2)
        {
            Console.WriteLine(num1 + num2);
        }

        public static string Add(int num1, int num2, bool answer)
        {

            int num3 = num1 + num2;
            //Console.WriteLine(num3);
            if (answer)
            {
                var grammar = num3 == 1 ? "dollar" : "dollars";

                return $"{num3} {grammar}";
            }
            else
            {
                return num3.ToString();
            }



        }
    }
}

