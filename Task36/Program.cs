// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//            Найдите сумму элементов, стоящих на нечётных позициях.

int[] getArray(int size, int min, int max)
{
    Console.Write("Массив: ");
    int[] locArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        locArray[i] = new Random().Next(min, max + 1);
    }
    foreach (int i in locArray)
    {
        Console.Write($" {i} ");
    }
    Console.WriteLine();
    return locArray;
}

int FindSum(int[] lArray)
{
    int s = 0;
    for (int i = 0; i < lArray.Length; i++)
    {
        if (i % 2 == 0) s = s + lArray[i];
    }
    return s;
}
Console.WriteLine(FindSum(getArray(8,1,10)));