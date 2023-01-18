// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19    [-4, -6, 89, 6] -> 0

int[] GetArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);

    }
    return array;
}

int getIntFromUser(string message)
{
    Console.WriteLine(message);
    int userInt = int.Parse(Console.ReadLine());
    return userInt;
}

int SumElementOddPosition(int[] array)
{
    int sum = 0;
    for(int i=0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int length1 = getIntFromUser("Введите размер массива: ");
int start1 = getIntFromUser("Введите начало интервала значений массива: ");
int end1 = getIntFromUser("Введите конец интервала значений массива: ");
int[] mass = GetArray(length1, start1, end1);
PrintArray(mass);
int summa = SumElementOddPosition(mass);
Console.WriteLine();
Console.WriteLine($"Сумма значений элементов массива на нечетных позициях равно {summa}");