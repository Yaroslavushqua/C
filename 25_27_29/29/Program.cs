/*
Задача 29: Напишите программу, которая задаёт массив произвольной длины, 
заполняет произвольными элементами и выводит их на экран.
Длину массива и элементы массива можно задать рандомно 
или попросить пользователя ввести в консоли.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.WriteLine("Введите длинну массива: ");
int countArr = int.Parse(Console.ReadLine());
int[] randomArr = new int[countArr];
for (int i = 0; i < randomArr.Length; i++)
{
    randomArr[i] = new Random().Next(1,99);
    Console.Write(randomArr[i] + ", ");
}