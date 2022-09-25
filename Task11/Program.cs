// Напишите программу, которая выводит случайное трехзначное
//  число и удалет вторю цифру этого числа
// 456 => 46
// 782 => 72
// 919 => 98

int number = new Random().Next(10,1000);
int RemoveSecondDigit(int num)
{
    int thirdDigit = num % 10;
    int firstDigit = num / 100;
    return firstDigit * 10 + thirdDigit;
}
int result = RemoveSecondDigit(number);
Console.WriteLine($"Итоговое число от {number} => {result}");