// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CheckSquare(numberA, numberB));

bool CheckSquare(int num1, int num2)
{
    return num1*num1 == num2 || num2*num2 == num1;
}