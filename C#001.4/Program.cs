Console.Write("Введите число  ");
int number = Convert.ToInt32(Console.ReadLine());
int res = 2;
int mn = number / 2;

while (mn > 0)
{
    res = res * mn;
    Console.Write(res);
    Console.Write(", ");
    res = 2;
    mn--;
}