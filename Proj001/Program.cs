/*  **Задача 19**

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int a;
Console.WriteLine("Enter a five-digit number: ");
int.TryParse(Console.ReadLine()!, out a);
if (a>=10000 && a<=99999 || a<=-10000 && a>=-99999)
{
    if (a/10000==a % 10 && a/1000 % 10 == a/10 % 10)
    {
        Console.Write($"This number is a palindrome");
    }
    else
    {
        Console.Write($"This number is not a palindrome");
    }
}
else
{
    Console.Write($"Oh my friend, this number is not five-digit!");
}