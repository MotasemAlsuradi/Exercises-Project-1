namespace Exercises_Project_1
{
    // Create My Custom Exception
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException() : base("The age is invalid.") { }

        public InvalidAgeException(string message) : base(message) { }
    }

    internal class Program
    {
        public static void PrintJaggedArray()
        {
            int[][] jaggedArray =
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5 },
                new int[] { 6, 7, 8, 9 }
            };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write("Row " + (i + 1) + ": ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static void PrintFibonacciSeries(int n)
        {
            int sumOfFibonacciSeries = 0;
            Console.Write("\nFibonacci Series: ");
            for (int i = 0; i < n; i++)
            {
                int fibNum = Fibonacci(i);
                sumOfFibonacciSeries += fibNum;
                Console.Write(fibNum + " ");
            }
            Console.WriteLine("\nSum of Fibonacci series: " + sumOfFibonacciSeries);
        }
        static void Main(string[] args)
        {
            
            PrintJaggedArray();


            
            try 
            {
                Console.WriteLine();
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());  

                if (age < 0 || age > 150)
                {
                    throw new InvalidAgeException();
                }

                Console.WriteLine($"Your age is: {age}");
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message); 
            }


            Console.WriteLine(); 
            Console.Write("Enter the number to get the Fibonacci sequence: ");
            int n = int.Parse(Console.ReadLine());

            PrintFibonacciSeries(n);
        }
    }
}
