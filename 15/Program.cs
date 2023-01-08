Console.Write("Введите цифру, обозначающую день недели: ");
int date = Convert.ToInt32(Console.ReadLine());

if (date == 6 || date == 7)
{
    Console.Write("Выходной день");
}
else if (date < 1 || date > 7)
{
    Console.Write("Такого дня не существует)");
}
else
{
    Console.Write("Будний день");
}