// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 999);
        index++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int pos = 0;
    while (pos < count)
    {
        Console.Write(coll[pos] + " ");
        pos++;
    }

}
int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine(" ");

int procChis = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        procChis++;
    }
}
Console.WriteLine($"В массиве находится {array.Length} чисел, {procChis} из них чётные.");