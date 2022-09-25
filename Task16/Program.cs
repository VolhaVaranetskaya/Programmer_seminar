// Напишите программу, котора принимает на вход два числа и проверяет,
//  является ли олно число квадратом второго
// 5,25 => да
// 4,16 => да
// 25,5 => да
// 8,9 => нет

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool Square(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}
if (Square(num1, num2)) Console.WriteLine($"{num1}, {num2} => Да!");
else Console.WriteLine($"{num1}, {num2} => Нет!");