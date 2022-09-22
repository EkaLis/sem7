// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

Console.WriteLine("Введите двумерный массив размером m/n ");
int row = Convert.ToInt32(Console.ReadLine());
int column = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateArray(row, column, -1, 10);
PrintArray(array);

double[,] CreateArray(int row, int column, int min, int max)
{
    double[,] result = new double[row, column];
    for(int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().NextDouble()*new Random().Next(min, max); 
        }
    }
    return result;
}


void PrintArray(double[,] array)
{
    int rows = array.GetLength(0);    
    int columns = array.GetLength(1);
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
