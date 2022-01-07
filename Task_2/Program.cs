// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int GetNumber()
{
    Console.WriteLine("Введите номер дня недели: ");
    int Number = Convert.ToInt32(Console.ReadLine());
    return Number;
}
void Weekend(int number)
{
    if(number>0 & number<8)
    {
        if(number<6)
        {
            Console.WriteLine("Сегодня будний день: ");
        }
        else Console.WriteLine("Сегодня выходной");
    }
    else Console.WriteLine("Вы ввели некорректный номер дня недели");
}
int SomeNumber = GetNumber();
Weekend(SomeNumber);