﻿// Домашняя задача 29:
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// 1 способ - ввод массива пользователем:
// Console.WriteLine("Самостоятельно создадим свой массив из 8 элементов. Введите по порядку цифры:");
// int[] array = new int[8];
// for (int i = 0; i < 8; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Получился массив: [ {String.Join("; ", array)} ]");

//2 способ - заполнение массива случайными числами:
int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(100);
}
Console.WriteLine($"Получился массив: [ {String.Join("; ", array)} ]");