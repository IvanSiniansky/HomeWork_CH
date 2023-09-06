// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

if (num1 % 2 == 0)
{
    Console.WriteLine(num1 + " -> да");
}
else
{
    Console.WriteLine(num1 + " -> нет");
}
