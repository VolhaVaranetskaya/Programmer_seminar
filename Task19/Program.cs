// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет является ли это число палиндромом
// 14212 - нет
// 23432 - да
// 12821 - да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Palindrom = (number);
{
if(number > 999 && number < 100000)
    {
        int Digit1 = number / 10000;
        int Digit2 = number / 1000 % 10;
        int Digit4 = number / 10 % 10;
        int Digit5 = number % 10;
        if(Digit1 == Digit5 && Digit2 == Digit4) Console.WriteLine($"Число {number} является палиндромом");
        else Console.WriteLine($"Число {number} не является палиндромом");
    }
else Console.WriteLine("Введено неверное число");
}