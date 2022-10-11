// Не используя рекурсию, выведите первые N чисел Фибоначчи (это 0 и 1)
// Если N = 5 => 01123;
// Если N = 3 => 011;
// Если N = 7 => 0112358;
// Числа Фибоначчи - это ряд чисел, в которых число равно сумме двух прдыдущих.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
PrintFibonacci(number);

void PrintFibonacci(int num)
{
    int firstNum = 0;
    int secondNum = 1;
    Console.Write($"{firstNum} {secondNum} ");

    for (int i = 2; i < num; i++) // так как извесны первые два числа, то начинаем с 2
    {
        int nextNum = firstNum + secondNum;
        Console.Write($"{nextNum}");
        firstNum = secondNum;
        secondNum = nextNum;
    }
}

//  Решение  с помощью рекурсии

// int number = 13;
// DecToBin(number);

// void DecToBin(int num)
// {
//     if(num == 0) return;
//     DecToBin(num / 2);
//     Console.Write(num % 2);
// }