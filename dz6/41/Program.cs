// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2
Console.Clear();
Console.WriteLine("Введите количествот чисел:");
int c =int. Parse (Console.ReadLine()!);
int count = 0;
for (int i = 0; i < c; i++)
{
Console.WriteLine ($"Введиете {i+1} число");
int a =int.Parse(Console.ReadLine()!);
if (a>0) count++;
}
Console.WriteLine ($"Чисел > 0 : {count}") ;