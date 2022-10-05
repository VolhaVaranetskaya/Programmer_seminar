// Задайте одномерный массив из 123 сучайных чисел. 
// Найдите количество элементов массива, 
// значения которых лежат в отрезке из 5 элементов.
// [5, 18, 123, 6, 2] - 1
// [1, 2, 3, 6, 2] - 0
// [10, 11, 12, 13, 14] - 5

int[] CreateArrayRndInt(int size, int min, int max) // метод для создания массива
{
    int[]array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array) // метод для печати массива
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]} ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}
int QuantityElemRange(int[] array, int min, int max) // метод для решения задачи, используем int, так как нам ужно целочисленное число, в скобках аргументы - это сам массив, где мы будем все считать, мин и макс значение
{
    int counter = default; // т к результат нам нужен в количестве, мы заводим соответствующую переменную и по умолчанию присваиваем ей 0
    for (int i = 0; i < array.Length; i++) // создаем цикл для того, чтобы перебрать каждый из элементов нашего массива и сравнить его со значениями отрезка
    {
        if(array[i] >= min && array[i] <= max) counter++;// если элемент массива больше мин и меньше мах, то мы увеличиваем счетчик и сравниваем след элемент
         // если условие if не выполнилось, то мы оставляем итоговое значение счетчика
    }
    return counter; // и возвращаем его, это и будет наш результат
}
int[] arr = CreateArrayRndInt(12, 0, 1000); //создаем новый массив
PrintArray(arr); // выводим его на печать
int quantityElemRange = QuantityElemRange (arr, 10, 99); //создаем результат, котороый хотим получить при помощи нашей функции, в качестве арумента-свежесозданный массив и мин и макс значения отрезка
Console.WriteLine(quantityElemRange); // выводим нужное число