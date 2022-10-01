// Напишите цикл, который принимает на вход да числа (А и В)
//  и возводит число А в натуральную степень В.
// 3,5 - 243 (3^5), 2,4 - 16 (2^4)

Console.WriteLine("Введите число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 > 0)
{
    int res = DegreeDigit(num1, num2);
    Console.WriteLine($"{num1} в степени {num2} => {res}");
}
else Console.WriteLine("Введено некорректное значение");

int DegreeDigit(int num1, int num2)
{
    int counter = 0;
    int res = 1;
    while (counter < num2)
    {
        res = num1 * res;
        counter++;
    }
    return res;
}



