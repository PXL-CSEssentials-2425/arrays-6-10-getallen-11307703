namespace _10_Getallen
{
    internal class Program
    {
        private static int[] numbers = new int[10];
        static void Main(string[] args)
        {
            Console.WriteLine("==Even getallen uit 10 tonen==");
            Console.WriteLine();
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Geef getal {i + 1}/10: " );
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("==Even getallen afdrukken==");
            
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine($"Getal {i + 1} is een even getal: {numbers[i]}");
                }
            }

        }
    }
}
