// 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

const int Size = 12;

int[] numbers = CreateRandomArray (Size);
PrintArray(numbers);
Console.WriteLine();
int positivesSum = CalcPositivesSum (numbers);
int negativeSum = CalcNegativesSum (numbers);
Console.WriteLine($"Сумма положительных равна {positivesSum}, сумма отрицательных равна {negativeSum}");

int[] CreateRandomArray (int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
    numbers[i] = new Random().Next(-9,10);
    }
    return numbers;
}

void PrintArray(int[] numbers)
{
    foreach(int number in numbers)
    {
        Console.Write($"{number} ");
    }
}

int CalcPositivesSum(int[] numbers)
{
    int sum = 0;
    foreach(int number in numbers) // для каждого числа number из массива чисел numbers
    {
        if (number > 0) sum +=number;
    }
    return sum;
}

int CalcNegativesSum(int[] numbers)
{
    int sum = 0;
    foreach(int number in numbers)
    {
        if (number < 0) sum +=number;
    }
    return sum;
}