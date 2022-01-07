// Найти расстояние между точками в пространстве 2D/3D

int GetNumber()
{
    Console.WriteLine("Введите число");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}
Console.WriteLine("В каком пространстве будем работать?");
Console.WriteLine("Нажмите 1 - если будем работать в 2D пространстве.");
Console.WriteLine("Нажмите 2 - если будем работать в 3D пространстве.");
int UserChoice = Convert.ToInt32(Console.ReadLine());
if(UserChoice==1)
{
    int X1 = GetNumber();
    int Y1 = GetNumber();
    int X2 = GetNumber();
    int Y2 = GetNumber();
    double result = Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2));
    Console.WriteLine("Расстояние между двумя точками в 2-мерном пространстве - {0}",result);
}
if(UserChoice==2)
{
    int X1 = GetNumber();
    int Y1 = GetNumber();
    int Z1 = GetNumber();
    int X2 = GetNumber();
    int Y2 = GetNumber();
    int Z2 = GetNumber();
    double result = Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2))+Math.Abs(Z2-Z1);
    Console.WriteLine("Расстояние между двумя точками в 3-мерном пространстве - {0}",result);
}