﻿/*Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
int n = new Random().Next(99,1000);
Console.WriteLine(n);

int first = n/100; 
int third = n%10;

Console.WriteLine(first + "" + third);