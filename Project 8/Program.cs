namespace Project_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MODEL1 = 1;
            const int MODEL2 = 2;
            const int MODEL3 = 3;
            const int LOWEST_RANDOM = 1;
            const int UPPER_RANDOM = 101;

            Random random = new Random();

            // Ask the user for the number of rows and columns
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert number of the model: " + MODEL1 + " - filled with numbers. " + MODEL2 + " - filled with letters. " + MODEL3 + " - filled with DJ-moticon.");
            int modelChoice = int.Parse(Console.ReadLine());

            if (modelChoice == MODEL1)
            {
                // 2D array with user-defined size
                int[,] array1 = new int[rows, cols];

                // Fill the array automatically with random numbers (from 1 till 100)
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        array1[i, j] = random.Next(LOWEST_RANDOM, UPPER_RANDOM); // inserts random value between 1 and 100
                    }
                }

                Console.WriteLine("\n The automatically filled 2D array:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(array1[i, j] + "\t");  // spaces for easy reading
                    }
                    Console.WriteLine();
                }
            }
            if (modelChoice == MODEL2)
            {
                string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
                Random random2 = new Random();
                int randomIndex = random2.Next(letters.Length);
                string randomLetter = letters[randomIndex];
                string[,] array2 = new string[rows, cols];
                Random rand = new Random();

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        array2[i, j] = letters[rand.Next(letters.Length)];
                    }
                }
                
                Console.WriteLine("Generated 2D Array:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(array2[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            if (modelChoice == MODEL3)
            {
                string DJ = "..d-_-b..";
                string[,] array3 = new string[rows, cols];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        array3[i, j] = DJ;
                    }
                }

                Console.WriteLine("Generated 2D Array:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(array3[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
