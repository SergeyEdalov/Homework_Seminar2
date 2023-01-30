// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter your number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a < 8 && a > 5)
{
    Console.WriteLine($"{a} день недели - выходной");
}
if (a < 6)
{
    Console.WriteLine($"{a} день недели - не выходной");
}
if (a > 7)
{
    Console.WriteLine("Ошибка, введите цифру от 1 до 7");
}
