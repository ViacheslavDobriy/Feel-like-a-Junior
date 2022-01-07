// Программа проверяет пятизначное число на палиндромом.

double GetNumber()
{
    Console.WriteLine("Введите 5-значное число: ");
    double Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}
void Palindrom(double number)
{
    if(number>9999 & number<100000)
    {
        if(Math.Round(number/10000-0.5)%10==number%10)
        {
            if(Math.Round(number/1000-0.5)%10==Math.Round(number/10-0.5)%10)
            {
                Console.WriteLine("Введенное вами число является палиндромом");
            }
            else Console.WriteLine("Введенное вами число не является палиндромом");
        }
        else Console.WriteLine("Введенное вами число не является палиндромом");
    }
    else Console.WriteLine("Вы ввели не пятизначное число");
}
double Number = GetNumber();
Palindrom(Number);
