Console.Clear();
int number = new Random().Next(10, 100);
Console.WriteLine("Случайное число: " + number);

int ostatok = number % 10;
Console.WriteLine("Последняя цифра: " + ostatok);

int first = number / 10;
Console.WriteLine("Первая цифра: " + first);
if (ostatok > first)
{
    Console.WriteLine("Наибольшее число: " + ostatok);
}
else
{
    Console.WriteLine("Наибольшее число: " + first);
}
