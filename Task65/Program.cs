// Найдите значениz M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M=1; N=5 => 1, 2, 3, 4, 5
// M=4; N=8 => 4, 5, 6, 7, 8

Console.WriteLine("Введите первое число: ");
int numberM = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberN = Convert.ToInt16(Console.ReadLine());
NaturalNumbersFromMtoN(numberM, numberN);

void NaturalNumbersFromMtoN(int numM, int numN)
{
    if (numM < numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbersFromMtoN(numM + 1, numN);
    }

    if (numM > numN)
    {
        Console.Write($"{numN} ");
        NaturalNumbersFromMtoN(numM - 1, numN);
    }

    if (numM == numN) Console.Write($"{numM} ");
}