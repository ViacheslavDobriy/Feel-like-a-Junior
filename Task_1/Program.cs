// Дано число. Проверить кратно ли оно 7 и 23
int GetNumber()
{
    Console.WriteLine("Введите число");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}
void Checking(int Number)
{
    if(Number%7==0)
    {
        Console.WriteLine("Введеное вами число делится на 7");
    }
    if(Number%23==0)
    {
        Console.WriteLine("Введенное вами число делится на 23");
    }
    if(Number%7!=0 & Number%23!=0)
    {
        Console.WriteLine("Введеное вами число некратно 7 и 23");
    }
}
int SomeNumber = GetNumber();
Checking(SomeNumber);

