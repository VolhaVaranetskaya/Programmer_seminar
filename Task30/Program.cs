// Напишите программу, которая вводит массив из 8 элементов,
//  заполненный нулями и единицами в случайном порядке


int[] array = new int[8];
GetArray(array);
PrintArray(array);

void GetArray(int[] arr)
{
    int length = arr.Length;
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array [i] }");
    }
    Console.WriteLine();
}