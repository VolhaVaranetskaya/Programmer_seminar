// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D  пространстве
// А (3,6,8) В (2,1,-7) = 15,84
// А (7,-5,0) В (1,-1,9) = 11,53

Console.WriteLine("Введите координаты первой точки ");
Console.Write("x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки ");
Console.Write("x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distanse3D(int argX1, int argY1, int argZ1, int argX2, int argY2, int argZ2)
{
    double res = Math.Sqrt(Math.Pow((argX2 - argX1), 2) + Math.Pow((argY2 - argY1), 2) + Math.Pow((argZ2 - argZ1), 2));
    return res;
}
double distanse = Distanse3D(x1, y1, z1, x2, y2, z2);
Console.WriteLine(Math.Round(distanse, 2, MidpointRounding.ToZero));