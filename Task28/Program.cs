// Напишите программу, которая принимае на вход число N 
//  выдает произведение чисел от 1 до N (факториал N)
//  4-24, 5-120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int result = DigitMultiplication(number);
    Console.WriteLine($"Факториалом числа {number} является {result}");
}
else Console.WriteLine("Введено некорректное значение");

int DigitMultiplication(int num)
{
    int multiplication = 1;
    for (int i = 1; i <= num; i++)
    {
        multiplication = multiplication * i;
    }
    return multiplication;
}