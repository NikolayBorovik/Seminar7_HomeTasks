// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

int GetNum(string numberName)
{
    System.Console.WriteLine($"Enter {numberName}");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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

void CheckNumInMatrix(int[,] matrix, int row, int column)
{
    if (row >= matrix.GetLength(0) || column >= matrix.GetLength(1))
        System.Console.WriteLine("The element does not exist.");
    else 
    {
        System.Console.WriteLine($"Your element is: {matrix[row, column]}");
    }
}

int indRow = GetNum("a row index: ");
int indColumn = GetNum("a column index: ");

int[,] matrix = GetMatrix(10, 10);

PrintMatrix(matrix);
System.Console.WriteLine();

CheckNumInMatrix(matrix, indRow, indColumn);





