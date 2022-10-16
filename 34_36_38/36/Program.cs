/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
fillArrayRandom(array);
Console.WriteLine("массив: ");
PrintArray(array);
int sum = 0;

for (int z = 1; z < array.Length; z+=2)
    sum +=array[z];
    Console.WriteLine($"сумма элементов на нечётных позициях = {sum}");

void fillArrayRandom(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(1,10);
    
    }
}
void PrintArray(int[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
