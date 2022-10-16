/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
fillArrayRandom(array);
Console.WriteLine("массив: ");
PrintArray(array);
int count = 0;

for (int z = 0; z < array.Length; z++)
if (array[z] % 2==0)
count++;

Console.WriteLine($"{count} из них чётные");

void fillArrayRandom(int[] array)
{
    for(int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99,1000);
    }
}
void PrintArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}