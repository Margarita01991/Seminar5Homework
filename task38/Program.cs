/* Задача 38: Задайте с клавиатуры массив вещественных (int) чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */
Console.Clear();
double[] array = new double[] {5.3, -30.12, 99.2, 205.2, 32, 4.1};
Console.WriteLine('['+ string.Join("  ", array) + ']');

double min = 0;
double max = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}
Console.WriteLine($"Разница между максимальным и минимальным элементом' = {max - min}");



// for (int i = 0; i <array.Length - 1; i++) 
// {
//     double minposition = i;
//     {
//         for (int j = i + 1 ; j <array.Length; j++)
//         {
//         if (array[j] < array[minposition]) minposition = j;
//         }
//     }

// }