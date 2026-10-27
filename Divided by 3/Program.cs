namespace Divided_by_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number / 3 == 0)
            {
                Console.WriteLine($"{number} can be divided by 3.");
            }
            else
            {
                Console.WriteLine($"{number} cannot be divided by 3.");
            }
        }
    }
}
