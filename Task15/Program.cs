//  Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет,
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
bool WeekDay (int arg)
{
    return arg >= 1 & arg <= 5;
}
if (WeekDay(num)) Console.WriteLine($"{num} не является выходным днем");
else Console.WriteLine($"{num} является выходным днем");