namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ListOfNumbers = new List<int>();
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                
                if (number == 0)
                {
                    break;
                }
                else
                {
                    ListOfNumbers.Add(number);
                }
            }

            int[] numbers = ListOfNumbers.ToArray();
            int positive = 0;
            int negative = 0;
            
            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    negative++;
                }
                else
                {
                    positive++;
                }
            }
            Console.WriteLine($"The amount of positive numbers is {positive} and of negative is {negative}");
        }
    }
}
