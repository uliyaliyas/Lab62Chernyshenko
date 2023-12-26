using System;
namespace MatrixLibrary
{
    public class MatrixOperations
    {
        public static void SwapMinMax(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int minElement = matrix[0, 0];
            int maxElement = matrix[0, 0];
            int minRow = 0, minColumn = 0, maxRow = 0, maxColumn = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] < minElement)
                    {
                        minElement = matrix[i, j];
                        minRow = i;
                        minColumn = j;
                    }
                    if (matrix[i, j] > maxElement)
                    {
                        maxElement = matrix[i, j];
                        maxRow = i;
                        maxColumn = j;
                    }
                }
            }
            int temp = matrix[minRow, minColumn];
            matrix[minRow, minColumn] = matrix[maxRow, maxColumn];
            matrix[maxRow, maxColumn] = temp;
        }
    }
}