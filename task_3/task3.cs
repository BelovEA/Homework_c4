//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, -5, 0, -11 -> [1, 2, 5, 7, 19, -5, 0, -11]


Console.WriteLine("Задача 29");
Console.Write("Данная программа запрашивает 8 целочисленных значений и выводит их на экран в виде массива");

Console.WriteLine();
int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}:\t ");
    array[i] = int.Parse(Console.ReadLine());
}

Console.Write("Вывод массива: ");
for (int i = 0; i < array.Length; i++)
{
    if (i == 7)
    {
        Console.Write(array[i]);
    }
    else
    {
        Console.Write($"{array[i]}, ");
    }
}