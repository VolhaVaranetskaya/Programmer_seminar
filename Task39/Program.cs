// Напишите программу , которая проверяет одномерный массив
//  (последний элемент будет на первом месте, а первый на пследнем и т д)
//  [1, 2, 3, 4, 5] - [5, 4, 3, 2 1]
//  [6, 7, 3, 6] - [6, 3 7 6]

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
void ReverseArray(int[] array)
{
    int size = array.Length;
    int index1 = 0;
    int index2 = size-1;
    while (index1 < index2)
    {
        int obj = array[index1]; // вводим временную переменную и заполняем ее
        array[index1] = array[index2]; //выпоняем замену двух элементов
        array[index2] = obj; // индекс 2 становится новой переменной

        index1++;
        index2--;
    }
}
int[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);
ReverseArray(arr);
PrintArray(arr);
