// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > numberN)
{
    int obj = numberM;
    numberM = numberN;
    numberN = obj;
}
int naturalSumRange = NaturalSumRange(numberM, numberN);
Console.WriteLine(naturalSumRange);

int NaturalSumRange(int numM, int numN)
{
    if (numM + 1 >= numN)
    {
        return numM + numN;
    }
    return numM + NaturalSumRange(numM + 1, numN);
}
