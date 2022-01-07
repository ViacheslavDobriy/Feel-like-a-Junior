// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int GetNumber()
{
    Console.WriteLine("Введите число");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}
int WhatQuarter(int First, int Second)
{
    if(First>0)
    {
        if(Second>0)
        {
            return 1;
        }
        else return 4;
    }
    else if(Second>0) return 2;
    else return 3;
}
int X = GetNumber();
int Y = GetNumber();
Console.WriteLine("Ваша точка находится в {0} четверти", WhatQuarter(X,Y));
