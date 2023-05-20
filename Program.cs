using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the Pascal's triangle row number: ");
        int rowNumber = int.Parse(Console.ReadLine());

        if (rowNumber < 0)
        {
            Console.WriteLine("Invalid Pascal's triangle row number.");
            return;
        }

        for (int i = 0; i <= rowNumber; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(CalculatePascalValue(i, j) + " ");
            }
            Console.WriteLine();
        }
    }

    static int CalculatePascalValue(int row, int column)
    {
        if (column == 0 || column == row)
        {
            return 1;
        }
        else
        {
            return CalculatePascalValue(row - 1, column - 1) + CalculatePascalValue(row - 1, column);
        }
    }
}
