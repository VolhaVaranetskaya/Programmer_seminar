// Найдите произведение пар чисел в одномерном массиве.
//  Парой считаем первый и последний элемент, 
//  второй и предпоследний и т д.Результат записать в новом массиве.
// [1, 2, 3, 4, 5] - 5, 8, 3
// [6, 7, 3, 6] - 36, 21

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
int[] MultiplicateFirstLastNum(int[] array) // метод создания целочисленного массива
{                                          // возвращать мы должны новый массив, его нужно создать, длина нового массива зависит от того, какое кол-во элементо было в исходно масииве - четное или нечтное
    int lengthNewArray = default;
    if (array.Length % 2 == 0) lengthNewArray = array.Length / 2; // выполняем проверку на четность путем определения остатка от деления на 2,если 0, то доина нового массива равна половнине от кол-аа элементов исходного
    else lengthNewArray = (array.Length / 2) + 1; // если не равно 0, то длина нового массива равна половина +1
    int[] newArray = new int[lengthNewArray]; // создали новый массив, в нем по умолчанию стоят 0, далее с помощью цикла for будем его заполнять

    for (int i = 0; i < newArray.Length; i++) // создаем цикл, который будет производит нужный нам подсчет(умножение элементов)
{
    newArray[i] = array[i] * array[array.Length - 1 - i]; //при подсчете нечетного кол ва элементов по этой формуле серединный элемент считается как квадрат числа, а это неправильно, поэтому создаем еще одно условие 
}

    if (array.Length % 2 == 1) newArray[newArray.Length - 1] = array[array.Length / 2];// последнее значение нового массива равно среднему значению исходного массива(квадрат среднегго числа приравниваем к этому числу, т е переписываем значение)
    return newArray;
}
int[] arr = CreateArrayRndInt(15, 0, 100);
PrintArray(arr);
int[] multiplicateFirstLastNum = MultiplicateFirstLastNum(arr);
PrintArray(multiplicateFirstLastNum);