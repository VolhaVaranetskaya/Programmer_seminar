// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int[] RealNumberDiff(int[] array)
{
    int maxNumber = default;
    int minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
    {
        maxNumber = array[i];
    } 
        if (array[i] < minNumber)
    {
        minNumber = array[i];
    } 
    }
    return new int[] {maxNumber, minNumber};
}
int[] arr = CreateArrayRndInt(5, 1, 10);
PrintArray(arr);
int[] realNumberDiff = RealNumberDiff(arr);
PrintArray(realNumberDiff);
int result = realNumberDiff[0] - realNumberDiff[1];
Console.WriteLine($"Разница между максимальным и минимальным элементами массива => {result} ");
Console.WriteLine();