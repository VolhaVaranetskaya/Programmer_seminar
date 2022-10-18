// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumElemOddInd(int[] array)
{
    int sumElem = 0;
    for (int i=1; i < array.Length; i=i+2)
    {
        {
            sumElem = array[i] + sumElem;
        }
    }
    return sumElem;
}
int[] arr = CreateArrayRndInt(7, -10, 10);
PrintArray(arr);
int sumElem = SumElemOddInd(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях массива => {sumElem}");