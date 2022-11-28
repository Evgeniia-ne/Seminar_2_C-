Console.Clear();
int number = new Random().Next(100, 999);
Console.WriteLine("Случайное число: " + number);

int first = number / 100;
Console.WriteLine("Первая цифра: " + first);

int third = number % 10;
Console.WriteLine("Третья цифра: " + third);

Console.WriteLine("Число без второй цифры: " + first + third);

//int result = (number / 100) * 10 + number % 10;
//Console.WriteLine( number + -> + result);