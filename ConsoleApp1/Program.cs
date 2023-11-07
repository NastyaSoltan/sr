namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {//реализовать функцию вычисления частного двух целых чисел
            Console.Write("Введите первое число: ");
            int dividend = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int divider = int.Parse(Console.ReadLine());
            Result(dividend, divider);
        }
        static void Result(int dividend, int divider)
        {
            int quotient = dividend / divider;
            Console.WriteLine($"{dividend} делить на {divider} равно {quotient}");
            Console.ReadKey();
        }
    }
        
}