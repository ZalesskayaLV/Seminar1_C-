/*
Напишите программу вычисления значения функции возведения числа в квадрат.
4 -> 16
-3 -> 9
-7 -> 49
*/ 

Console.Write("Введите число X: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = (number*number);

Console.Write("квадрат X: ");
Console.WriteLine(result);