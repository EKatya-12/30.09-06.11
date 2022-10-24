// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Console.WriteLine("Кол-во чисел для ввода:");
// int count = int.Parse(Console.ReadLine());
// Console.WriteLine("Вводите числа:");
// int[] array = new int[count];
// int counter = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = int.Parse(Console.ReadLine());
//     if(array[i] > 0)
//     {
//         counter++;
//     }
// }

// Console.WriteLine("Массив");
// for (int i = 0; i < array.Length; i++)
// {
//     Console.WriteLine(array[i]);
// }
// Console.Write("Чисел больше нуля: " + counter);




Console.WriteLine("Кол-во чисел для ввода:");
int count = int.Parse(Console.ReadLine());
Console.WriteLine("Вводите числа:");

int counter = 0;
void GreateThanZero (int counter)
{
   int[] array = new int[count];
   for (int i = 0; i < array.Length; i++)
   {
      array[i] = int.Parse(Console.ReadLine());
      if(array[i] > 0)
      {
        counter++;
      }
   }
   Console.WriteLine("Чисел больше нуля: " + counter);
} 

GreateThanZero(counter);


