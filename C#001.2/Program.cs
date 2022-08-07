Console.Write("Введите 1 число  ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число  ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2 число  ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    int max = number1;
    if (max > number3)
    {
        Console.Write("max = ");
        Console.Write(max);
    }
    else
    {
        max = number3;
        Console.Write("max = ");
        Console.Write(max);
    }
}
else if (number1 > number3)
{
    int max = number1;
    if (max > number2)
    {
        Console.Write("max = ");
        Console.Write(max);
    }
    else
    {
        max = number2;
        Console.Write("max = ");
        Console.Write(max);
    }
}
else if (number2 > number3)
{
    int max = number2;
    Console.Write("max = ");
    Console.Write(max);
}
else
{   
    Console.Write("max = ");
    Console.Write(number3);
}