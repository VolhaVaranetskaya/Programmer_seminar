// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество вводимых чисел М");
int number = Convert.ToInt32(Console.ReadLine());

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
int MoreZeroNumbers(int[] array)
{
    int counter = default;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) counter++;
    }
    return counter;
}
int[] arr = CreateArrayRndInt(number, -10, 10);
PrintArray(arr);
int moreZeroNumbers = MoreZeroNumbers(arr);
// PrintArray(arr);
Console.WriteLine($"Количество чисел больше 0 => { moreZeroNumbers} ");


// int moreZeroNumbers = ConvertMoreZeroNum(number);
// Console.WriteLine($"Количество чисел больше 0 => {moreZeroNumbers}");

// int ConvertMoreZeroNum (int num)
// {
//     int moreZeroNumbers = default;
//     int counter = default;
//     for (int i = 0; i < number; i++)
//     {
//         if(num > 0) counter++;
//         //else counter;
//     }
//     return counter;
// }
