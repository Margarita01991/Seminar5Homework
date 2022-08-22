/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
Console.Clear();
int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int [] arr = new int [size];
    for(int i = 0; i <arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange +1);
    }
    return arr;
}

int[] array = FillArray (8,100, 1000);
Console.WriteLine('['+ string.Join(", ", array) + ']');
int count = 0;
for(int i = 0; i <array.Length; i++)
{
    if (array[i]%2 ==0)
    {
        count++;
    }
}
Console.WriteLine(count);
