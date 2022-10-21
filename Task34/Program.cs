// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// var rnd = new Random();
// int count = rnd.Next(3, 10);
// int[] array = new int[count];
// int counter = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rnd.Next(100, 999);
//     if (array[i] % 2 == 0)
//     {
//         counter++;
//     }
//     Console.WriteLine(array[i]);
// }
// Console.WriteLine(counter);


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();      
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int Count (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 == 0) count++;
    }
    return count;
}

int[] arr = CreateArrayRndInt(4, 100, 999);
PrintArray(arr);

int count = Count (arr);
Console.WriteLine ($"количество четных элементов массива = {count}");