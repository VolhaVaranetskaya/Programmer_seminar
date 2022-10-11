// Напишите програииу, которая будет преобразовывать десятичное число в двоичное
// 45 - 101101, 3 - 11, 2 - 10, 3 - 1101

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int binaryNumUnreversed = ConvertNumberToBinary(number);
Console.WriteLine($"{number} => {binaryNumUnreversed}");
int ConvertNumberToBinary(int num)
{
    int binaryNumUnreversed = default;
    int count = 1;
    while (num > 0)
    {
        binaryNumUnreversed = binaryNumUnreversed + num % 2 * count;
        count = count*10; // увеличиваем на порядок (1, 10, 100, 1000, 100000 и тд)
        num = num / 2;
    }
    return binaryNumUnreversed;
}