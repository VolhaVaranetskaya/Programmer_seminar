 // Напишите программу, которая принимает на вход число (N) и выдат таблицу квадратов чисел от 1 до N
// 5 => 1, 4, 9, 16, 25
// 2 => 1, 4

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void SquareTable(int number)
{
    int counter = 1;
    while(counter <= number)
    {
        Console.WriteLine($"{counter}  {counter * counter}");
        counter++;
    }
}
if(num > 0) SquareTable(num);
else Console.WriteLine("Введено некорректное значение");
