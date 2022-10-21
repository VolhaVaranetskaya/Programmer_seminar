// Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число");
int number = Convert.ToInt16(Console.ReadLine());
int sum = SumOfDigits(number);
Console.WriteLine(sum);

int SumOfDigits(int num) 
{
    int sum = num % 10;
    if(num > 0) sum += SumOfDigits(num / 10);
    return sum;
}
