using Shared;

var order = ConsoleExtension.GetInt("Enter the order of the matrix: ");

int[,] matrix = new int[order, order];

// Fill the matrix with values
for (int i = 0; i < order; i++)
{
    for (int j = 0; j < order; j++)
    {
        matrix[i, j] = i + j;
    }
}

// Print the matrix
for (int i = 0; i < order; i++)
{
    for (int j = 0; j < order; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

// Print the hourglass pattern
Console.WriteLine("HOUR GLASS");
for (int i = 0; i < order; i++)
{
    for (int j = 0; j < order; j++)
    {
        if (i <= j && i + j < order || i >= j && i + j >= order - 1)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        else
        {
            Console.Write("\t");
        }
    }
    Console.WriteLine();
}
