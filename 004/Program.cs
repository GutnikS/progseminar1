// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите число ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
int index = 0;
while (index < (firstnumber-1))
{
    index = index + 2;
    Console.Write ($"{index} ");
}