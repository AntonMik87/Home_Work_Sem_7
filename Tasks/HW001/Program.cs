// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
Console.Clear();
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
            Console.Write($"Позиция: {x} = Строка: {index1}, Стобец: {index2} ");
            return;
        }
   }

}
Console.WriteLine($"Такого элемента нет");