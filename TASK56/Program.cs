// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/// <summary>
/// Метод, который заполняет двумерный массив определенными параметрами.
/// </summary>
/// <param name="rows">Количество строк.</param>
/// <param name="cols">Количество столбцов.</param>
/// <param name="minValue">Минимальное значение.</param>
/// <param name="maxValue">Максимальное</param>
/// <returns>Возвращает двумерный массив заполненный случайными числами, с заданным количеством строк и столбов,
/// и определенным интервалом минимальноых и максимальных чисел </returns>
int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}
/// <summary>
/// Выводит в консоль заданный двумерный массив.
/// </summary>
/// <param name="matr"></param>
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int m = 0; m < matr.GetLength(1); m++)
        {
            Console.Write(matr[i, m] + "\t");
        }
        Console.WriteLine();
    }
}
/// <summary>
/// Метод, который находит в определенном двумерном масиве строку с наименьшей суммой элементов.
/// </summary>
/// <param name="matrix"></param>
void SumRows(int[,] matrix)
{
    int minIndex = 0;
    int minSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];   
        }
        if (i==0)
        {
            minSum=sum;
            minIndex = i+1;
        }
        else if (sum < minSum)
        {
            sum = minSum;
            minIndex = i+1;
        }
    }
    Console.WriteLine($"В {minIndex} строке наименьшая сумма элементов.");
}
int[,] resultMatrix = GetMatrix(3, 3, 0, 10);
Console.WriteLine("Массив:");
PrintMatrix(resultMatrix);
Console.WriteLine();
SumRows(resultMatrix);