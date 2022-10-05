/*
Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
Console.Write("Введите номер дня недели (от 1 до 7): ");
int weekDay=Convert.ToInt32(Console.ReadLine());
while (weekDay<1|weekDay>7){
Console.Write("Вы ввели недопустимый номер дня недели, повторите ввод (от 1 до 7): ");
weekDay=Convert.ToInt32(Console.ReadLine());
}
if (weekDay==1) Console.WriteLine("Понедельник - не выходной");
else if (weekDay==2) Console.WriteLine("Вторник - не выходной");
else if (weekDay==3) Console.WriteLine("Среда - не выходной");
else if (weekDay==4) Console.WriteLine("Четверг - не выходной");
else if (weekDay==5) Console.WriteLine("Пятница - не выходной, но подожди до завтра");
else if (weekDay==6) Console.WriteLine("Суббота - УРА! ВЫХОДНОЙ!");
else if (weekDay==7) Console.WriteLine("Воскресенье - выходной, но завтра уже нет");
//else Console.WriteLine("Вы ввели недопустимый номер дня недели");