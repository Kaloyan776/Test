namespace TEST17._04._2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;
            int max = int.MinValue;
            int Constant = 9;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] == Constant)
                {
                    count++;
                }
            }

            Console.WriteLine($"Сума на елементите: {sum}");
            Console.WriteLine($"Най-голям елемент: {max}");
            Console.WriteLine($"Числото 9 се среща {count} пъти");


        }
    }
}
