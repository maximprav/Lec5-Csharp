

string[,] table = new string[2, 5];

// table [0,0], table [0,1] ... 0,4
// table [1,0], table [1,1] ... 1,4

// table[1, 2] = "Привет!";

// for(int rows=0; rows<2; rows++)
// {
//     for(int columns=0; columns<5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

void PrintArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) // rows < matrix.GetLength(0) Это первый ряд
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) // columns < matrix.GetLength(1) Это второй ряд
        {
            Console.Write($"{matr[rows, columns]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int rows = 0; rows < matr.GetLength(0); rows++) // rows < matrix.GetLength(0) Это первый ряд
    {
        for (int columns = 0; columns < matr.GetLength(1); columns++) // columns < matrix.GetLength(1) Это второй ряд
        {
            matr[rows, columns] = new Random().Next(1, 10); // [1,10)
        }
    }
}

Console.Clear();
int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);