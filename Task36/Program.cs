// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// var rnd = new Random();
// int count = rnd.Next(3, 10);
// int[] array = new int[count];
// int counter = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rnd.Next(-50, 50);
//     if (i % 2 != 0)
//     {
//         counter+= array[i];
//     }
//     Console.WriteLine(array[i]);
// }
// Console.WriteLine("Сумма чисел: "+counter);


int[] CreateArrayRndInt(int size, int min, int max)
{
    var array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}


void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] GetSumOddNumbers (int[] array)
{
    int sum = default;
        
    for (int i = 0; i < array.Length; i++)
    if (i % 2 != 0)
    {
        sum += array[i];
    }
    return new int[] {sum};
}

int[] arr = CreateArrayRndInt(4, -100, 100);
PrintArray(arr);

int[] result = GetSumOddNumbers(arr);

Console.WriteLine($"Сумма чисел, стоящих на нечётных позициях = {result[0]}");
