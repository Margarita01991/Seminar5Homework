/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
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
int[] array = FillArray (5, -30, 99);
Console.WriteLine('['+ string.Join(", ", array) + ']');
int sum = 0;
for(int i = 1; i <array.Length; i+=2) // вместо i=0;...; i++
{
//    if (i%2 != 0)
    sum = sum + array[i];
}
Console.WriteLine(sum);

// Сумма нечетных элементов
// for(int i = 0; i <array.Length; i++) 
// {
//     if (array[i]%2 != 0)
//     sum = sum + array[i];
// }
// Console.WriteLine(sum);