// Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100,1000);
int ShowSecondDigit(int number)
{
    int result1 = number / 10;
    int result2 = result1 % 10;
    return result2;
}
int result2 = ShowSecondDigit(number);
Console.WriteLine($"Вторая цифра числа {number} => {result2}");