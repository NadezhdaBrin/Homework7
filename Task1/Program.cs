// Найти произведение двух матриц

void fillArray(int[,] arr, int start, int end)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = rnd.Next(start, end + 1);
    }
}

void printArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(String.Format("{0,4}", arr[i, j]));
        Console.WriteLine();
    }

}
void multiplyMatrices(int[,] arr1, int[,] arr2)
{
    if (arr1.GetLength(1) == arr2.GetLength(0))
    {
        int[,] productArr = new int[arr1.GetLength(0), arr2.GetLength(1)];
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                for (int k = 0; k < arr2.GetLength(0); k++)
                {
                    productArr[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }
        printArray (productArr);
    }

    else Console.WriteLine(" невозможно умножить матрицы ");
}

int a = 5, b = 3;
int[,] array1 = new int[a, b];
int m = 3, n = 4;
int[,] array2 = new int[m, n];
fillArray(array1, 1, 5);
fillArray(array2, 1, 5);
Console.WriteLine($"матрица1: ");
printArray(array1);
Console.WriteLine($"матрица2: ");
printArray(array2);
Console.WriteLine($"Произведение двух матриц = ");
multiplyMatrices(array1, array2);
