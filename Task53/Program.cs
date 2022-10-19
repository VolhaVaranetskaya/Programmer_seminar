// Задайте двумерный массив. Напишите прогамму, которая поменяет
//  местами первую и последнюю строку массива.

int[,] MyArray = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(MyArray);
NewArray(MyArray);
Console.WriteLine();
PrintMatrix(MyArray);

void NewArray(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)  // используе 1 цико for , т к нужно работать только со строками
    {
        int obj = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = obj;
    }
}

int[,] CreateMatrixRndInt(int rows, int columns, int min=0, int max=5)
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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}