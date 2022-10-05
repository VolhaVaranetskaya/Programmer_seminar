// Напишите программ замены элементов массива, 
// положитльные элементы замените на соответствующие отрицательные и наоборот
// [-4, -8, 8, 2] - [4, 8, -8, -2]

int[] CreateArray(int size, int min, int max)
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
        if(i < array.Length - 1) Console.WriteLine($"{array[i]} ");
        else Console.WriteLine($"{array[i]}");
    }
    Console.Write("]");
}
int[] InversionNum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
}
int[] arr = CreateArray(4, -8, 8);
PrintArray(arr);
int[] inversionNum = InversionNum(arr);
PrintArray(inversionNum);
