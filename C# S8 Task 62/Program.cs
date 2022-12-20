// Task 62

int[,] SpiralFillArray(int a)
{
    int size = a;
    int[,] fillMass = new int[size, size];
    int row = 0;
    int col = 0;
    for (int i = 1; i <= size * size; i++)
    {
        fillMass[row, col] = i;
        if (row <= col + 1 && row + col < size - 1) col++;
        else if (row < col && row + col >= size - 1) row++;
        else if (row >= col && row + col > size - 1) col--;
        else row--;
    }
    return fillMass;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
Console.Clear();
Console.Write("Введите длину массива: ");
int dim = int.Parse(Console.ReadLine()!);
PrintArray(SpiralFillArray(dim));