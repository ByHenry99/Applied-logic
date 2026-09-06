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
        Console.Write(matrix[i, j]+"\t");
    }
    Console.WriteLine();
}

// Print the lower triangular matrix
for (int i = 0; i < order; i++)
{
    for (int j = 0; j < order; j++)
    {
        if (i >= j)
        {
            Console.Write(matrix[i, j]+"\t");
        }
        else
        {
            Console.Write("\t");
        }
    }
    Console.WriteLine();
}
