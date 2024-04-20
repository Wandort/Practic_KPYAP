class Program
{
    static void Main()
    {
        int n = 7;
        int[,] spiralMatrix = new int[n, n];

        int num = 1;
        int rowStart = 0, rowEnd = n - 1;
        int colStart = 0, colEnd = n - 1;

        while (num <= n * n)
        {
            for (int i = colStart; i <= colEnd; i++)
            {
                spiralMatrix[rowStart, i] = num++;
            }
            rowStart++;

            for (int i = rowStart; i <= rowEnd; i++)
            {
                spiralMatrix[i, colEnd] = num++;
            }
            colEnd--;
            
            for (int i = colEnd; i >= colStart; i--)
            {
                spiralMatrix[rowEnd, i] = num++;
            }
            rowEnd--;

            for (int i = rowEnd; i >= rowStart; i--)
            {
                spiralMatrix[i, colStart] = num++;
            }
            colStart++;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(spiralMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}