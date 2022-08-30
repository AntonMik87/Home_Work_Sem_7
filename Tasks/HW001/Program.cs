// Console.Clear();
int x = int.Parse(Console.ReadLine() ?? "0");
int[,] matr = new int[5, 5];
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = new Random().Next(1, 10);
        Console.Write($" {matr[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        if (matr[i, j] == x)
        {
            int index1 = i;
            int index2 = j;
            Console.Write($"Позиция: {index1},{index2} ");
            return;
        }
   }

}
Console.WriteLine($"Такого элемента нет");