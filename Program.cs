Console.Write("Введите число  ");
int number = Convert.ToInt32(Console.ReadLine());

number = number % 2;
if (number == 0)
{
    Console.Write("Четное");
}
else
{
    Console.Write("Нечетное");
}