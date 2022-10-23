// Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое число: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 && numberN < 0) Console.Write("Введены неверные числа");
else
{
    int akkerman = Akkerman(numberM, numberN);
    Console.WriteLine(akkerman);
}

int Akkerman(int numM, int numN)
{
    int akkerman = 0;
    if (numM == 0) akkerman = numN + 1;
    if (numM > 0 && numN == 0) akkerman = Akkerman(numM - 1, 1);
    if (numM > 0 && numN > 0) akkerman = Akkerman(numM - 1, Akkerman(numM, numN - 1));
    return akkerman;
}