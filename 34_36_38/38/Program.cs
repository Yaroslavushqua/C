/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
fillArrayRandom(array);
Console.WriteLine("Массив: ");
PrintArray(array);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0;  z < array.Length; z++)
{
    if (array [z] > max)
    {
        max = array [z];
    }
    if (array [z] < min)
    {
        min = array [z];
    }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void fillArrayRandom(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}