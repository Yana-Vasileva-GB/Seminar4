/* Домашняя задача 25
Напишите цикл, который принимает на вход два числа (A и B) и
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

// 1) при помощи for:
// Console.WriteLine("Введите число А:");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число B:");
// int B = Convert.ToInt32(Console.ReadLine());
// double result = 0;
// for (int i = 1; i <= B; i++)
// {
//     result = Math.Pow(A, B);
// }
// Console.WriteLine($"{A} в степени {B} составляет {result}");

// 2) при помощи while:
Console.WriteLine("Введите число А:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int B = Convert.ToInt32(Console.ReadLine());
double result = 0;
int i = 1; 
while (i <= B) 
{
    result = Math.Pow(A, B);
    i++;
}
Console.WriteLine($"{A} в степени {B} составляет {result}");