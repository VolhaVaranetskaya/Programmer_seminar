 // Напишите программу, которая выводит случайное число из отрезка [10,99] 
// и показывает наибольшую цифру числа
// 78 => 8
// 12 => 2
// 85 => 8

int MaxDigit (int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit > secondDigit) return firstDigit;
    return secondDigit;
}
int number = new Random().Next(10,100);
int result = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа {number} = {result}");