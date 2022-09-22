// Напишите программу, которая на вход принмает одно число (N), 
// а на выходе показывает все целые числа
//  в промежутке от -N до N

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int counter = -num;

while (counter <= num)
{
    Console.Write(counter++ + " ");
}
