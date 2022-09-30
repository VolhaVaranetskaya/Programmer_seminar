// Напишите программу, которая принимает на вход число
//  и выдает количество цифр в число
// 456 - 3, 89126 - 5

Console.WriteLine("Введит число: ");
int number = Convert.ToInt32(Console.ReadLine());

int QuantityNumbers(int num)
{
    int counter = 0;
    while (num > 0)
    {
        num = num / 10;
        counter++;
    }
    return counter;
}
int res = QuantityNumbers(Math.Abs(number));
Console.WriteLine($"Количество цифр числа {number} => {res}");