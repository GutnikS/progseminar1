// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
Console.Write("Введите первое число ");
int firstnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int secondnumber = Convert.ToInt32(Console.ReadLine());
if (firstnumber > secondnumber) Console.WriteLine(firstnumber);
    else
    {
        Console.Write("Максимальное число: ");
        Console.WriteLine(secondnumber);
    }