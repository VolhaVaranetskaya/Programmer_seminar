// Напишите программу, которая на вход принимает два числа А и В
//  и возводит число А в целую степень В с помощью рекурсии.
// А=3, В=5 -> 243 (3 в 5 степени)
// А=2, В=3 -> 8 (2 в 3 степени)

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt16(Console.ReadLine());
int result = GetPowNum(number1, number2);
Console.WriteLine(result);

int GetPowNum(int num, int pow)
{
    if(pow == 0) return 1;
    int res = num;
    res *= GetPowNum(num, pow - 1);
    return res;
}