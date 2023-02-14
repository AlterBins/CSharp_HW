Console.WriteLine("Введите неотрицательное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"-> {FunctionAkkerman(m, n)}");

int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FunctionAkkerman(m - 1, 1);
    else return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}