namespace ProjectOne
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // You can instantiate your Calculator class and call methods here, if needed.
            var calculator = new Calculator();
            int sum = calculator.Add(2, 3);
            Console.WriteLine($"Sum of 2 and 3 is: {sum}");
        }
    }
}
