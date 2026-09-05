using Shared;

var number = ConsoleExtension.GetInt("Enter the order of the matrix: ");

int[,] matrix = new int[number, number];

// Fill the matrix with values
for (int i = 0; i < number; i++)
{
    for (int j = 0; j < number; j++)
    {
        matrix[i, j] = i + j;
    }
}

// Print the matrix
for (int i = 0; i < number; i++)
{
    for (int j = 0; j < number; j++)
    {
        Console.Write(matrix[i, j]+"\t");
    }
    Console.WriteLine();
}

// Print the lower triangular matrix
for (int i = 0; i < number; i++)
{
    for (int j = 0; j < number; j++)
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
