namespace GenericsFindMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Program to find the Maximum problem using Generics");

            Console.WriteLine("\nExecuting three test cases to find the maximum value among three values");

            Console.WriteLine("\nTest case 1: ");
            int max1 = GenericClass<int>.FindMaxValue(80, 45, 60);
            Console.WriteLine($"{max1} is the greatest Integer among three number");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 2: ");
            float max2 = GenericClass<float>.FindMaxValue(4.5f, 7.5f, 3.3f);
            Console.WriteLine($"{max2} is the greatest Float among three number");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 3: ");
            string max3 = GenericClass<string>.FindMaxValue("Peach", "Apple", "Orange");
            Console.WriteLine($"{max3} is the greatest String among three number");
        }
    }
}
