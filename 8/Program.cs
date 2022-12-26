int a = 1;
Console.Write("Введите число N: ");
int b = int.Parse(Console.ReadLine());
for (int i = a; i <= b; i++)
{
    if (i % 2 == 0) 
    Console.Write(i + " ");
}