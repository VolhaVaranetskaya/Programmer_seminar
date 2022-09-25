// // Напишите программу, которая приимает на входе число и проверяет, 
// кратно ли оно одновременно 7 и 23
// 14 => нет
// 46 => нет
// 161 => да

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Aliquot(int arg)
{
    return arg % 7 == 0 && arg % 23 == 0;
}
if (Aliquot(number)) Console.WriteLine("Да!");
else Console.WriteLine("Нет!");