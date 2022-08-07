Console.Write("Введите 1 число  ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число  ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.Write("max = ");
    int max = number1;
    Console.Write(max);
}
else
{
    Console.Write("max = ");
    int max = number2;
    Console.Write(max);
}