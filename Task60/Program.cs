// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] matrix3D = Create3DMatrixRndInt(2, 2, 2, 0, 50);
PrintMatrix3D(matrix3D);
Console.WriteLine();

int[,,] Create3DMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    int[] valueMatrix = new int[rows * columns * depth];
    int count = 0;
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);
                while (NumberInMatrix(valueMatrix, matrix[i, j, k]))
                {
                    matrix[i, j, k] = rnd.Next(min, max + 1);
                }
                valueMatrix[count] = matrix[i, j, k];
                count++;
            }
        }
    }
    return matrix;
}

void PrintMatrix3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k],2} ({i}, {j}, {k})");
            }
        }
        Console.WriteLine();
    }
}

bool NumberInMatrix(int[] array, int num)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            result = true;
            break;
        }
    }
    return result;
}