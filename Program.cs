namespace GenericsFindMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Program to find the Maximum problem using Generics");

            Console.WriteLine("Executing three test cases to find the maximum numbe among three numbers");

            Console.WriteLine("\nTest case 1: ");
            int max1 = MaxInteger.FindMaxInt(80, 45, 60);
            Console.WriteLine($"{max1} is the greatest among three number");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 2: ");
            int max2 = MaxInteger.FindMaxInt(40, 70, 30);
            Console.WriteLine($"{max2} is the greatest among three number");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 3: ");
            int max3 = MaxInteger.FindMaxInt(20, 45, 50);
            Console.WriteLine($"{max3} is the greatest among three number");
            

        }
    }
}
