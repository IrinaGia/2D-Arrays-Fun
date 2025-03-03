namespace Project_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // Ask the user for the number of rows and columns
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            // 2D array with user-defined size
            int[,] array = new int[rows, cols];

            // Fill the array automatically with random numbers (from 1 till 100)
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = random.Next(1, 101); // inserts random value between 1 and 100
                }
            }

            Console.WriteLine("\nThe automatically filled 2D array:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + "\t");  // spaces for easy reading
                }
                Console.WriteLine();
            }
        }
    }
}
