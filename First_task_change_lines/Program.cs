// 1. Написать программу, которая обменивает элементы первой строки и последней строки.

int[,] matrix = new int[2, 4];
for(int row = 0; row < matrix.GetLength(0); row++)
  {
       for(int column = 0; column < matrix.GetLength(1); column++)
       {
       matrix[row, column] = new Random().Next(2, 10);
       }
    
  }  

for(int row = 0; row < matrix.GetLength(0); row++)
  {
       for(int column = 0; column < matrix.GetLength(1); column++)
       {
    Console.Write($"{matrix[row, column]} ");
    }
Console.WriteLine();
}
Console.WriteLine();


int[,] newMatrix = new int [2,4];
for(int i = 1; i < newMatrix.GetLength(0); i--)
{
      for(int j = 0; j < newMatrix.GetLength(1); j++)
      {
         
        newMatrix[i, j] = matrix[i, j];
        Console.Write($"{newMatrix[i, j]} ");
      }
    Console.WriteLine();
}
