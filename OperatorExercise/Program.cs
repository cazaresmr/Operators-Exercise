namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
Use Console.WriteLine(); and string interpolation to write out the results in the following format for each operation:
$"{a}/{b} is {quotient} remainder {remainder}."
Output to console for the above string interpolation should look like this:
17/4 is 4 remainder 1
            */
            int a = 17;
            int b = 4;
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} + {b} is {sum}");
            Console.WriteLine($"{a} - {b} is {difference}");
            Console.WriteLine($"{a} * {b} is {product}");
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
        }
    }
}
