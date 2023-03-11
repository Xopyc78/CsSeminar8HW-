// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/// <summary>
/// Метод,который задает трехмерный массив рандомными случайными двузначными числами.
/// </summary>
/// <param name="rows">количество строк</param>
/// <param name="cols">количество столбцов</param>
/// <param name="depth">глубина матрицы</param>
/// <returns>Возвращает трехмерный массив заполненный случайными двузначными числами.</returns>
int[,,] GetMatrix(int rows, int cols, int depth)
{
    int[,,] matrix = new int[rows, cols, depth];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                matrix[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return matrix;
}
/// <summary>
/// Выводит трехмерный массив.
/// </summary>
/// <param name="matr"></param>
void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}{(i,j,k)}\t");
            }
        }
        Console.WriteLine();
    }
}
int[,,] resultMatrix = GetMatrix(2, 2, 2);
Console.WriteLine("Массив:");
PrintMatrix(resultMatrix);
