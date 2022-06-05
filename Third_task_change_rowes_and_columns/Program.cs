
//3. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
Console.Clear();
Console.WriteLine("Для правильного выполнения условия, количество строк должно равняться количеству столбцов!");
Console.Write("Введите количесвто строк: ");
int n = int.Parse(Console.ReadLine()?? "");
Console.Write("Введите количесвто колонок: ");
int m = int.Parse(Console.ReadLine()?? "");
int[,] matrix = new int[n,m];

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1,10);
    }
}
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
     }
     Console.WriteLine();
}
Console.WriteLine();
if(m == n)
{
for(int j = 0; j < matrix.GetLength(1); j++)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write($"{matrix[i, j]} ");
     }
     Console.WriteLine();
}
}
else
{
    Console.WriteLine("Невозможно поменять строки и колонки местами, т.к. матрица заполнения массива на являестя квадратной.");
}
Console.WriteLine();