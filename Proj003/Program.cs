/*  **Задача 23** 

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125  */

int a;

Console.WriteLine("Enter a number: ");
int.TryParse(Console.ReadLine()!, out a);

int i;
int b=1;

for (i=1; i<=a; i++)
{
    b = i*i*i;
    Console.WriteLine($"{b} ");
}