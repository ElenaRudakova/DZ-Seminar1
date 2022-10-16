//Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int namber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваши четные числа");
int i = 1;
while (i <= namber)
{
    if (i % 2 == 0)
Console.WriteLine ("{0}",i);i++;

}