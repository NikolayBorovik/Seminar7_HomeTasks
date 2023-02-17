// // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

double[,] GetMatrixDouble(int rows, int columns)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

double[] AvgOfColumns(double[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double count = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            count += matrix[j,i];
        }
        result[i] = count/matrix.GetLength(0);
    }
    return result;
}

double[,] matrix = GetMatrixDouble(5,5);

PrintMatrixDouble(matrix);

double[] array = AvgOfColumns(matrix);

System.Console.Write($"Arithmetic average of each column is: ");
System.Console.WriteLine(String.Join("; ", array));


