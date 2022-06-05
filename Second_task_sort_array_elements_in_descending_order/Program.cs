// 2.Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива.

Console.Clear();
Console.WriteLine();
int[,] matrix = new int [3,4];
for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(1, 10);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for(int i = 0; i < matrix.GetLength(0); i++)
{
    int tmp = 0;
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        for(int k = 0; k < matrix.GetLength(1) - 1 - j; k++)
        {
            if(matrix[i,k] < matrix[i, k + 1])
            {
               tmp = matrix[i, k];
               matrix[i, k] = matrix[i, k + 1];
               matrix[i, k + 1] = tmp;
            }
        }
     
    } 
     Console.WriteLine();  
} 

for(int i = 0; i < matrix.GetLength(0); i++)
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}