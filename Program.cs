using System;

namespace Determinant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" _______________________________________");
            Console.WriteLine("|                                       |");
            Console.WriteLine("| Determinant calculator of the matrix  |");
            Console.WriteLine("|_______________________________________|");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Enter the size of square matrix: ");

            int sizeOfMatrix = int.Parse(Console.ReadLine());

            double[,] matrix = new double[sizeOfMatrix, sizeOfMatrix];
            Console.WriteLine("Enter the elemets of the matrix row by row, separate the elemenets by the blank (space)");

            for(int i = 0; i < sizeOfMatrix; ++i)
            {
                string rowInput = Console.ReadLine();
                for(int j = 0; j < sizeOfMatrix; ++j)
                {
                    matrix[i, j] = Array.ConvertAll(rowInput.Split(), double.Parse)[j];
                }
            }

            double determinant = MatrixMethods.Determinant(matrix);

            Console.WriteLine($"Determinant of the mattrix is: {determinant}");
            Console.Write("Press any key to exit program:");
            Console.ReadKey();
        }
    }
}