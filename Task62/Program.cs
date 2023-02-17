// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

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

int[,] matrix = new int[9, 9];

int filler = 10;
int rowStart = 0;
int colStart = 0;
int rowEnd = matrix.GetLength(0); // 4
int colEnd = matrix.GetLength(1); // 4

int[,] FillArrayInSpiral(int[,] matrix)
{
    if (QtyOFRecurs(rowEnd, colEnd))
    {
        int j = colStart;
        int i = rowStart;                   // 1. слева-направо: строка 0, столбцы от 0 до конца
        for (j = colStart; j < colEnd; j++)
        {
            matrix[i, j] = filler;
            filler++;
        }

        j = colEnd - 1;                     // 2. сверху-вниз: столбец ПОСЛЕДНИЙ, строки 1+1(!!!) до конца

        for (i = i + 1; i < rowEnd; i++)
        {
            matrix[i, j] = filler;
            filler++;
        }

        i = rowEnd - 1;                     // 3. справа-налево: строка ПОСЛЕДНЯЯ, столбцы от ПОСЛЕДНИЙ - 1 до НАЧАЛА

        for (j = colEnd - 2; j > colStart-1; j--)
        {
            matrix[i, j] = filler;
            filler++;
        }

        j = colStart;                     // 4. снизу-вверх: стобец ПЕРВЫЙ, строки от ПОСЛЕДНЕЙ - 1 до ПЕРВОЙ - 1

        for (i = rowEnd - 2; i > rowStart; i--)
        {
            matrix[i, j] = filler;
            filler++;
        }
        rowStart += 1;
        colStart += 1;
        rowEnd -= 1;
        colEnd -= 1;

        FillArrayInSpiral(matrix);
    }
    return matrix;
}

bool QtyOFRecurs(int rowEnd, int colEnd)
{
    return rowEnd >= 0 && colEnd >= 0 && rowStart < matrix.GetLength(0) && colStart < matrix.GetLength(1);
}

FillArrayInSpiral (matrix);
PrintMatrix(matrix);
