/*
Напишите программу, которая принимает на вход число
и выдаёт сумму цифр в числе.
*/

int GetSum(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

Console.WriteLine("Программа для вычисления суммы цифр в числе.");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {number} равна {GetSum(number)}");