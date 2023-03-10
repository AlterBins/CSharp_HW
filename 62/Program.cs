int n = 4;
int[,] matrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= matrix.Length)
{
    matrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= matrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > matrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j],2} ");

            else Console.Write($"{array[i, j],3} ");
        }
        Console.WriteLine();
    }
}

PrintMatrix(matrix);