// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int size = ReadInt("Введите размер массива: ");
int min = ReadInt("Введите минимум диапазона массива: ");
int max = ReadInt("Введите максимум диапазона массива: ");
double[] array = new double[size];
double maxNumber = min;
double minNumber = max;
double DiffNumber = 0;

Random dob = new Random();
Random num = new Random();

FillArrayRundomNumbers(array, min, max);
WriteFillArray(array);

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > maxNumber)  maxNumber = array[i];
    
    if(array[i] < minNumber)  minNumber = array[i];
}

 DiffNumber = maxNumber - minNumber;
 Console.WriteLine($"{maxNumber} - {minNumber} = {DiffNumber:0.00}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRundomNumbers(double[] number, int min, int max)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = Math.Round(dob.NextDouble() * num.Next(min, max + 1), 2) ;
    }
}

void WriteFillArray(double[] number)
{
    for(int i = 0; i < (number.Length); i++)
    {
        Console.Write($"{number[i]}  ");
    }
    Console.WriteLine();
}
