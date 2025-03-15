namespace Project_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MODEL1 = 1;
            const int MODEL2 = 2;
            const int MODEL3 = 3;
            const int MODEL1_LOWEST_RANDOM = 1;
            const int MODEL1_UPPER_RANDOM = 101;

            

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
                Random model1_random = new Random();
                int[,] model1_array = new int[rows, cols];

                // Fill the array automatically with random numbers (from 1 till 100)
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        model1_array[i, j] = model1_random.Next(MODEL1_LOWEST_RANDOM, MODEL1_UPPER_RANDOM); // inserts random value between 1 and 100
                    }
                }

                Console.WriteLine("\n The automatically filled 2D array:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(model1_array[i, j] + "\t");  // spaces for easy reading
                    }
                    Console.WriteLine();
                }
            }
            if (modelChoice == MODEL2)
            {
                string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
                Random model2_random = new Random();
                int randomIndex = model2_random.Next(letters.Length);
                string[,] model2_array = new string[rows, cols];
                Random letters_rand = new Random();

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        model2_array[i, j] = letters[letters_rand.Next(letters.Length)];
                    }
                }
                
                Console.WriteLine("Generated 2D Array:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(model2_array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            if (modelChoice == MODEL3)
            {
                string DJ = "..d-_-b..";
                string[,] model3_array = new string[rows, cols];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        model3_array[i, j] = DJ;
                    }
                }

                Console.WriteLine("Generated 2D Array:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(model3_array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
