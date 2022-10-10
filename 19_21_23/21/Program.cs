/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
Console.WriteLine("A1 (x1;y1), A2 (x2;y2), A3 (z1;z2)");

Console.Write("Input x1: ");
int x1=Convert.ToInt32(Console.ReadLine());

Console.Write("Input y1: ");
int y1=Convert.ToInt32(Console.ReadLine());

Console.Write("Input z1: ");
int z1=Convert.ToInt32(Console.ReadLine());

Console.Write("Input x2: ");
int x2=Convert.ToInt32(Console.ReadLine());

Console.Write("Input y2: ");
int y2=Convert.ToInt32(Console.ReadLine());

Console.Write("Input z2: ");
int z2=Convert.ToInt32(Console.ReadLine());

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

Console.WriteLine("A1A2A3 lenght is: "+Math.Round(Math.Sqrt(A * A + B * B + C * C),2));
