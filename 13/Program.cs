Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int DigitFind(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
        {
            number = number / 10;
        }
        result = number % 10;
    }
    return result;
}

if (DigitFind(number) == -1)
{
Console.WriteLine("Третьей цифры не существут");
}
else
{
Console.WriteLine($"Третья цифра: {DigitFind(number)}");
}
