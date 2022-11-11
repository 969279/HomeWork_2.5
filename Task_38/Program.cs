// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size = ReadInt("Введтие размер массива: ");
double[] array = new double[size];

Random rnd = new Random();

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void ReadArray(double[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = rnd.NextDouble();
    }
}

void WriteArray(double[] numbers)
{
    for(int i = 0; i < (numbers.Length - 1); i++)
    {
        Console.Write($"{numbers[i]:0.00}, ");
    }
    Console.WriteLine($"{numbers[numbers.Length - 1]:0.00} ");
}

ReadArray(array);
WriteArray(array);
