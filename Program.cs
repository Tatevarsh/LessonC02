// Задача 15: Напишите программу, которая принимает на 
// вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.WriteLine("Введите число от 1-7");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.WriteLine("выходной день");
}

else

{
    Console.WriteLine("рабочий день");
}




