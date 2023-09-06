//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.WriteLine("Введите второе число");
string strNum1 = Console.ReadLine();
int num2 = int.Parse(strNum1);

int max = num1;

if (num2 > num1)
{
    max = num2;
    Console.WriteLine("Максимальное значение: ");
    Console.WriteLine(max);
}
else
{
    max = num1;
    Console.WriteLine("Максимальное значение: ");
    Console.WriteLine(max);
}