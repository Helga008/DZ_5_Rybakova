// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

double[] GetArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble();

    }
    return array;
}

int getIntFromUser(string message)
{
    Console.WriteLine(message);
    int userInt = int.Parse(Console.ReadLine());
    return userInt;
}

void PrintArray(double[] array)
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

int length = getIntFromUser("Введите размер массива: ");

double[] mass = GetArray(length);

PrintArray(mass);

double max = mass[0];
double min = mass[0];

for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > max)
    {
        max = mass[i];
    }
    else if (mass[i] < min)
    {
        min = mass[i];
    }
}

Console.WriteLine();

Console.WriteLine($"Разница между максимальным ({max}) и минимальным ({min}) элементами массива равна {max - min}");

