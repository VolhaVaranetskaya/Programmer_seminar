// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FirstMatrix = CreateMatrixRndInt(2, 3, 1, 3);
PrintMatrix(FirstMatrix);
Console.WriteLine();
int[,] SecondMatrix = CreateMatrixRndInt(3, 2, 1, 3);
PrintMatrix(SecondMatrix);
Console.WriteLine();
if (FirstMatrix.GetLength(1) == SecondMatrix.GetLength(0))
{
    int[,] multiMatrices = MultiMatrices(FirstMatrix, SecondMatrix);
    PrintMatrix( multiMatrices);
}
else Console.WriteLine("Произведение данных матриц невозможно");


int[,] MultiMatrices(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] matrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            for (int k = 0; k < matrixOne.GetLength(1); k++)
            {
                matrix[i, j] = matrix[i, j] + matrixOne[i, k] * matrixTwo[k, j];
            }
        }
    }
    return matrix;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("]");
    }
}










