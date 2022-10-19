// Задайте двуменый массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] MyArray = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(MyArray);
Console.WriteLine();

bool  ChekMatrix(int[,] myArray)
{
    return myArray.GetLength(0) == myArray.GetLength(1);
}
if (ChekMatrix(MyArray))
PrintMatrix(ReplaceRowsColumns(MyArray));
else Console.WriteLine("Невозможно заменить строки на столбцы");

int[,] ReplaceRowsColumns(int[,] matrix)
{
    int[,] newArray = new int[matrix.GetLength(1), matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newArray[i, j] = matrix[j, i];
        }
    }
    return newArray;
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

