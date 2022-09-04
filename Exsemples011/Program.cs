// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int randomNum = new Random().Next(100, 1000);
Console.WriteLine(randomNum);
int digitFirst = randomNum / 100;
int digitSecond = randomNum % 10;
int result = digitFirst * 10 + digitSecond;
Console.WriteLine(result);