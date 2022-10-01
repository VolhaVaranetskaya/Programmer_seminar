// Напишите программу, которая задает массив из 8 элементов,
//  заполненный псевдослучайными числами и выводит их на экран

int[] array = new int[8];
int[] ArrayEight = GetArray(array);
PrintArray(array);

int[]GetArray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next();
    }
    return arr;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
}
