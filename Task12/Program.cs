// // Напишите программу, котрая будет принимать на вход числа и выводить, 
// является ли первое число кратным второму. Если 1 число не кратно 2 числу, 
// то программа выводит остаток от деления. 
// 34,5 => не кратно, остаток 4
// 16,4 => кратно

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool Aliquat(int arg1, int arg2)
{
    return arg1 % arg2 == 0;
}
if (Aliquat(num1, num2)) Console.WriteLine($"{num1} кратно {num2}");
else Console.Write($"{num1} не кратно {num2} остаток {num1 % num2}");