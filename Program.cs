namespace GenericsFindMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Program to find the Maximum problem using Generics");

            Console.WriteLine("Executing three test cases to find the maximum Float number among three numbers");

            Console.WriteLine("\nTest case 1: ");
            float max1 = MaxFloat.FindMaxFloat(6.5f, 4.5f, 3.2f);
            Console.WriteLine($"{max1} is the greatest among three number");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 2: ");
            float max2 = MaxFloat.FindMaxFloat(4.1f, 7.2f, 3.3f);
            Console.WriteLine($"{max2} is the greatest among three number");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 3: ");
            float max3 = MaxFloat.FindMaxFloat(2.2f, 4.5f, 5.6f);
            Console.WriteLine($"{max3} is the greatest among three number");
            

        }
    }
}
