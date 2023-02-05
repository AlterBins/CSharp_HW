int[] NewArrowRandom(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void ArrowPrint(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length -1)
        Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
int[] array = NewArrowRandom(4, 0, 50);
ArrowPrint(array);
int OddElements(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
    if (i % 2 == 1)
    result += arr[i];
    }
    return result;
}
int oddNumber = OddElements(array);
Console.WriteLine($"-> {oddNumber}");