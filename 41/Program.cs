Console.Write("Введите элементы (через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int Elements(int[] arr)
{
    int numbers = 0;
    for (int M = 0; M < arr.Length; M++)
    {
        if (arr[M] > 0) numbers++;
    }
    return numbers;
}
int numbers = Elements(arr);
Console.WriteLine($"-> {numbers}");