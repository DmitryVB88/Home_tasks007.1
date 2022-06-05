// В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.Clear();
int[,] matrix = new int [4,5];
for(int i = 0; i < matrix.GetLength(0); i++)
{
   for(int j = 0; j < matrix.GetLength(1); j++)
   {
       matrix[i, j] = new Random().Next(1, 10);
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

int minSum = Int32.MaxValue;
int count = 1;
   for(int i = 0; i < matrix.GetLength(0); i++)
    {
       int sum = 0;
       for(int j = 0; j < matrix.GetLength(1); j++)
       {
           sum = sum + matrix[i, j];
       }
    Console.WriteLine($"Сумма {i + 1}-й строки = {sum} ");
    if(sum < minSum)
    {
    minSum = sum;   
    }
    } 
Console.WriteLine();
Console.Write($"Минимальная сумма элементов массива = {minSum}.");

Console.WriteLine();


