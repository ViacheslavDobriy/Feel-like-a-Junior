// Задать номер четверти, показать диапазоны для возможных координат

int GetNumber()
{
    Console.WriteLine("Введите номер четверти:");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}
void Range(int Number)
{
    if(Number>0 & Number<5)
    {
        if(Number==1) Console.WriteLine("Вы ввели {0} номер четверти, это означает, что вам доступен диапазон координат только для X > 0 и Y > 0", Number);
        if(Number==2) Console.WriteLine("Вы ввели {0} номер четверти, это означает, что вам доступен диапазон координат только для X < 0 и Y > 0", Number);
        if(Number==3)Console.WriteLine("Вы ввели {0} номер четверти, это означает, что вам доступен диапазон координат только для X < 0 и Y < 0", Number);
        if(Number==4)Console.WriteLine("Вы ввели {0} номер четверти, это означает, что вам доступен диапазон координат только для X > 0 и Y < 0", Number);
    }
    else Console.WriteLine("Вы ввели некорректный номер четверти!");
}
int NumberOfQuarter = GetNumber();
Range(NumberOfQuarter);
