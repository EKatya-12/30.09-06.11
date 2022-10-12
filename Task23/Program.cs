// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

Cubes(number);

void Cubes (int num)
{
    int count = 1;
    Console.WriteLine($"Таблица кубов чисел от 1 до {num}");
    while (count <= num)
    {
        Console.WriteLine($"|{count,4}|{Math.Pow(count, 3),4}|");
        count++;
    }
}

