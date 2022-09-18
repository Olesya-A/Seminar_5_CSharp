// 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = CreateRandomArray(123);
PrintArray(array);
int count = CalcNumbers(array);
Console.WriteLine(count);



int[] CreateRandomArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(0, 1000);
    }
    return numbers;
}

void PrintArray(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.Write($"{number} ");
    }
    Console.WriteLine();
}

int CalcNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 9 && numbers[i] < 100) count += 1;
    }
    return count;
}
