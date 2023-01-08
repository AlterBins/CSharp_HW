Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = number / 10 % 10;

Console.Write("Вторая цифра: ");
Console.WriteLine(result);