// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
/// <summary>
/// Метод, который заполняет определенными параметрами.
/// </summary>
/// <param name="rows">Количество строк.</param>
/// <param name="cols">Количество столбцов.</param>
/// <param name="minValue">Минимальное значение.</param>
/// <param name="maxValue">Максимальное</param>
/// <returns>Возвращает массив заполненный случайными числами, с заданным количеством строк и столбов,
/// и определенным интервалом минимальноых и максимальных чисел </returns>
int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(minValue,maxValue+1);
        }
    }
    return matrix;
}
/// <summary>
/// Выводит в консоль заданный массив.
/// </summary>
/// <param name="matr"></param>
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int m = 0; m < matr.GetLength(1); m++)
        {
            Console.Write(matr[i,m]+ "\t");
        }
        Console.WriteLine();
    }
}
/// <summary>
/// Метод, который ранжирует по убыванию каждую строку двуммерного массива.
/// </summary>
/// <param name="matrix"></param>
void ArrangeRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                if (matrix[i,j]>matrix[i,k])
                {
                temp = matrix[i,j];
                matrix[i,j] = matrix[i,k];
                matrix[i,k] = temp;
                }  
            } 
        }
    }      
}
int [,] resultMatrix = GetMatrix(6,6,0,10);
Console.WriteLine("Первоначальный массив:");
PrintMatrix(resultMatrix);
Console.WriteLine();
Console.WriteLine("Массив после ранжировки строк по убыванию:");
ArrangeRows(resultMatrix);
PrintMatrix(resultMatrix);