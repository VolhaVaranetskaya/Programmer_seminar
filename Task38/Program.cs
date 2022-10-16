// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble(), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

double[] RealNumberDiff(double[] array)
{
    double maxNumber = default;
    double minNumber = array[0];
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
    return new double[] {maxNumber, minNumber};
}
double[] arr = CreateArrayRndInt(10, 10, 100);
PrintArray(arr);
double[] realNumberDiff = RealNumberDiff(arr);
PrintArray(realNumberDiff);
double result = Math.Round(realNumberDiff[0] - realNumberDiff[1], 2);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива => {result} ");
Console.WriteLine();
