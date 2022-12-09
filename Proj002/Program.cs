/*  **Задача 21**

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53    */

int xa, xb, ya, yb, za, zb;

Console.WriteLine("Enter X coordinates of point A: ");
int.TryParse(Console.ReadLine()!, out xa);
Console.WriteLine("Enter Y coordinates of point A: ");
int.TryParse(Console.ReadLine()!, out ya);
Console.WriteLine("Enter Z coordinates of point A: ");
int.TryParse(Console.ReadLine()!, out za);
Console.WriteLine("Enter X coordinates of point A: ");
int.TryParse(Console.ReadLine()!, out xb);
Console.WriteLine("Enter Y coordinates of point A: ");
int.TryParse(Console.ReadLine()!, out yb);
Console.WriteLine("Enter Z coordinates of point A: ");
int.TryParse(Console.ReadLine()!, out zb);

int x = (xb - xa)*(xb - xa);
int y = (yb - ya)*(yb - ya);
int z = (zb - za)*(zb - za);

double dist = Math.Sqrt(x + y + z);

Console.Write($"Distance between points in 3D space = {Math.Round(dist,2)}");