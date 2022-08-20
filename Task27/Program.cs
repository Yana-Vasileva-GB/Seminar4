// Домашняя задача 27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Найду сумму чисел в вашем числе. Введите любую цифру:");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (number>0)
{
    int sum = number % 10;
    number = number / 10;
    result = result + sum;
}
Console.WriteLine($"Сумма чисел составляет {result}");
