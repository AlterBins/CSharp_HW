Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
void Quarto()
{
    int count = 1;
    while (count <= n)
    {
    Console.WriteLine($"Число {count} в кубе --> {count * count * count}");
    count++;
    }
}
Quarto();