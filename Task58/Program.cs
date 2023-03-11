// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
int[,] firstMatrix = GetMatrix(2, 3, 0, 10);
int[,] secondMatrix = GetMatrix(3, 4, 0, 10);
int[,] multipliedMatrixes= new int[firstMatrix.GetLength(0),secondMatrix.GetLength(1)];
Console.WriteLine("Первый матрица:");
PrintMatrix(firstMatrix);
Console.WriteLine();
Console.WriteLine("Вторая матрица:");
PrintMatrix(secondMatrix);
for (int i = 0; i < firstMatrix.GetLength(0); i++)
{
    for (int j = 0; j < firstMatrix.GetLength(1); j++)
    {
        for (int k = 0; k <= secondMatrix.GetLength(1)-1; k++)
        {
            multipliedMatrixes[i,k]+=firstMatrix[i,j]*secondMatrix[j,k];
        }
    }
}
Console.WriteLine();
Console.WriteLine("Результат умножения первой матрицы на вторую:");
PrintMatrix(multipliedMatrixes);
