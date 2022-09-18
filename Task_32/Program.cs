// 32: Напишите программу замена элементов массива:
//  положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] array = CreateRandomArray(4);
PrintArray(array);
Console.WriteLine();
int[] ChanchedArray = CreateChangedArray(array);
PrintArray(ChanchedArray);

int[] CreateRandomArray(int size)
{
    int[] numbers = new int[size];
    for (int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(-10, 11);
    }
    return numbers;
}

void PrintArray(int[] numbers)
{
    foreach (int number in numbers)
    {
        Console.Write($"{number} ");
    }
}

int[] CreateChangedArray(int[] numbers)
{
    int size = numbers.Length;
    for (int i = 0; i < size; i++)
    {
        numbers[i] = -numbers[i];
    }
    return numbers;
}


