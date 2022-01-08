// Найти расстояние между точками в пространстве 2D/3D

int GetNumber()
{
    Console.WriteLine("Введите число");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}
/*int GetX(int Number)
{
    Console.WriteLine("Введите X координату {0} точки ", Number);
    int X = Convert.ToInt32(Console.ReadLine());
    return X;
}
int GetY(int Number)
{
    Console.WriteLine("Введите Y координату {0} точки ", Number);
    int Y = Convert.ToInt32(Console.ReadLine());
    return Y;
}
int GetZ(int Number)
{
    Console.WriteLine("Введите Z координату {0} точки ", Number);
    double Z = Convert.ToInt32(Console.ReadLine());
    return Z;
}*/
Console.WriteLine("В каком пространстве будем работать?");
Console.WriteLine("Нажмите 2 - если будем работать в 2D пространстве.");
Console.WriteLine("Нажмите 3 - если будем работать в 3D пространстве.");
int UserChoice = Convert.ToInt32(Console.ReadLine());
if(UserChoice==2)
{
    double[,] array= new double[2,2];
    for(int j=0;j<UserChoice;j++)
    {
        for(int i=0;i<UserChoice;i++)
        {
            array[j,i] = GetNumber();
        }
    }
    double result = Math.Sqrt(Math.Pow((array[1,0]-array[0,0]),2)+Math.Pow((array[1,1]-array[0,1]),2));
    Console.WriteLine("Расстояние между двумя точками в 2-мерном пространстве - {0}",result);
}
if(UserChoice==3)
{
    double[,] array = new double[2,3];
    for(int j=0;j<UserChoice-1;j++)
    {
        for(int i=0;i<UserChoice;i++)
        {
            array[j,i] = GetNumber();
        }
    }
    double result = Math.Sqrt(Math.Pow((array[1,0]-array[0,0]),2)+Math.Pow((array[1,1]-array[0,1]),2))+Math.Abs(array[1,2]-array[0,2]);
    Console.WriteLine("Расстояние между двумя точками в 3-мерном пространстве - {0}",result);
}