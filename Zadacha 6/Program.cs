// Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");
int number_1 = Convert.ToInt32(Console.ReadLine());
int number_2 = number_1%2;

if (number_2>0)
{
   Console.WriteLine("Число нечетное"); 
}
else 
{
    Console.WriteLine("Число четное");
}