//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Введите первое число");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.WriteLine("Введите второе число");
string strNum1 = Console.ReadLine();
int num2 = int.Parse(strNum1);

Console.WriteLine("Введите третье число");
string strNum2 = Console.ReadLine();
int num3 = int.Parse(strNum2);

int max = num1;

if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}

Console.WriteLine("Максимальное значение: ");
Console.WriteLine(max);