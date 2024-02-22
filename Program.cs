namespace recursion
{
    internal class Program
    {
        static Random random = new Random();

        // Рекурсивна функція для обчислення суми елементів масиву
        static int SumArray(int[] arr, int n)
        {
            if (n == 1)
            {
                return arr[0];
            }
            else
            {
                return arr[n - 1] + SumArray(arr, n - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введіть розмір масиву: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(1, 101);
            }

            int result = SumArray(arr, size);
            Console.WriteLine($"Масив: [{string.Join(", ", arr)}]");
            Console.WriteLine($"Сума елементів масиву: {result}");
        }
    }
}
