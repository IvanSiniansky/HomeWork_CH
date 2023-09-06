// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

int evenNum = 2;

if(num1 > 1)
{
    while (evenNum <= num1)
    {
        Console.Write(evenNum + " ");
        evenNum = evenNum + 2;
    }
}