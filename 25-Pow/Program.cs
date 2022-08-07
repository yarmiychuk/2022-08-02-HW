/*
Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
*/

double GetPow(double number, double pow)
{
    double result = 1;

    for (int i = 0; i < pow; i++)
    {
        result *= number;
    }

    return result;
}

bool IsCorrectInput(double num)
{
    return (num > 0);
}

Console.WriteLine("Программа для вычисление степени от числа");
Console.Write("Введите число: ");
double number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральную степень, в которую нужно возвести число: ");

double pow;
while (!IsCorrectInput(pow = Convert.ToInt32(Console.ReadLine())))
{
    Console.Write("Вы ввели неправильное число! Повторите ввод: ");
}

Console.WriteLine($"{number}^{pow} = {GetPow(number, pow)}");