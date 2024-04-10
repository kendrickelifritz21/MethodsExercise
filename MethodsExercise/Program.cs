namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Enter your favorite food: ");
            var food = Console.ReadLine();

            Console.WriteLine("Enter your favorite band: ");
            var band = Console.ReadLine();

            Console.WriteLine("Enter your favorite day of the week: ");
            var day = Console.ReadLine();

            Console.WriteLine($"{name} spends their {day}s eating {food} and listening to {band}.");


            // Exercise 2
            var sum = Sum(1, 2, 3, 4, 5);
            Console.WriteLine($"The sum of 1, 2, 3, 4, and 5 is {sum}.");

            var product = Multiply(5, 7);
            Console.WriteLine($"The product of 5 and 7 is {product}.");
        }

        private static int Sum(params int[] input)
        {
            var sum = 0;
            foreach (var i in input)
            {
                sum += i;
            }
            return sum;
        }

        private static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
