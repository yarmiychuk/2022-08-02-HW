/*
Напишите программу, которая задаёт массив из 8 элементов
и выводит их на экран.
*/

int arraySize = 8; 

void ShowArray(int[] array)
{
    Console.Write("Введённый массив:");
    for (int i = 0; i < arraySize; i++)
    {
        Console.Write(" " + array[i]);
        if (i < arraySize - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine();
}

Console.WriteLine("Программа для создания и отображения массива из 8 элементов");
int[] array = new int[arraySize];
for (int i = 0; i < arraySize; i++)
{
    Console.Write($"Введите элемент {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

ShowArray(array);