// Задайте двумерный массив. Надите сумму элементов, 
// находящихся на главной диагонали (с индексами 0,0; 1,1; и т д)

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
int sumElemDiagonal = FindSumElemDiagonal(array2D);
Console.WriteLine($"Сумма элементов главной диагонали равна {sumElemDiagonal}");

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j]}  ");
            else Console.Write($"{matrix[i,j]}  ");
        }
        Console.WriteLine("]");
    }
}

int FindSumElemDiagonal(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(i == j) sum = sum + matrix[i,j];
        }
    }
    return sum;
}