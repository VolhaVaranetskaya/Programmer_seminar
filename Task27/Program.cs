//Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
// 452 - 11 (4+5+2); 82 - 10 (8+2) 

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumDigit(number);
Console.WriteLine($"Сумма чисел {number} => {result}");

int SumDigit(int num)
{
    int sum = 0;
    while(num > 0)
    {
    result = num % 10;
    sum = sum + result;
    num = num / 10;
    }
    return sum;
}