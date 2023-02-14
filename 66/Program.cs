Console.WriteLine("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"-> {SummaDigits(m, n)}");

int SummaDigits(int num1, int num2)
{
    if (num1 == num2) return num1;
    else if (num1 < num2) return num2 + SummaDigits(num1, num2 - 1);
    else return num2 + SummaDigits(num1, num2 + 1);
}