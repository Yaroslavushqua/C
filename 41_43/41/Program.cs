/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Write("Введите числа через запятую: ");
int [] arrayNum = StringToNum(Console.ReadLine());
int sum = 0;
for (int i = 0; i < arrayNum.Length; i++)
{
    if (arrayNum [i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"Кол-во чисел больше 0 = {sum}");

int [] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }
    int [] arrayNum = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
            if (i != input.Length - 1)
            {
                temp += input [i].ToString();
                i++;
            }
            else
            {
                temp += input [i].ToString();
                break;
            }
        }
        arrayNum[index] = Convert.ToInt32(temp);
    index++;
    }
    return arrayNum;    
}