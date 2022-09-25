// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool TwoDigitNumb(int arg)
{
    return arg / 100 == 0;
}
if (TwoDigitNumb(number)) Console.WriteLine("Третьей цифры нет");
else
{
    while (number >= 1000)
    {
        number = number / 10;
    }
        int result = number % 10;
        Console.WriteLine($"Третья цифра числа => {result}");
}