// Задайте массив заполненный случайными положительными трёхзначными числами. 
// На
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[]array = new int[size];
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
        if(i < array.Length - 1) Console.Write($"{array[i]} ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int[] AmountHonestNumb (int[] array, int min, int max)
{
    int counter = default;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0);
        counter++;
    }
    return counter;
}
int[] arr = CreateArrayRndInt(10, 100, 999);
PrintArray(arr);
int[] amountHonestNumb = AmountHonestNumb (arr, 100, 1000);
Console.WriteLine(amountHonestNumb);

