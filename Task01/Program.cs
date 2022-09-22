// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int square = number1 * number2;

if (number1 == square)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}