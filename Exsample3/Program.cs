// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем\


int [] arr()
{
    int [] array = new int [8];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write ($" Введите число под индексом {i} ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}


int[] array = arr();
Console.WriteLine(string.Join(", ", array));

