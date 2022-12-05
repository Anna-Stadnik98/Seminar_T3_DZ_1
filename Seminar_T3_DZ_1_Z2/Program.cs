// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter number1: ");
string enterNum1 = Console.ReadLine();
Console.Write("Enter number2: ");
string enterNum2 = Console.ReadLine();
int num1 = Convert.ToInt32(enterNum1);
int num2 = Convert.ToInt32(enterNum2);
if ( num1 > num2 )
{
    Console.Write("max: ");
    Console.WriteLine(enterNum1);
    Console.Write("min: ");
    Console.WriteLine(enterNum2);
}
else
{
    Console.Write("max: ");
    Console.WriteLine(enterNum2);
    Console.Write("min: ");
    Console.WriteLine(enterNum1);
}
