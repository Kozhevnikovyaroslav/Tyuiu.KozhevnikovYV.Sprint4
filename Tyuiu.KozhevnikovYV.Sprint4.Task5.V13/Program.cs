using Tyuiu.KozhevnikovYV.Sprint4.Task5.V13.Lib;
DataService ds = new DataService();

Console.Title = "Спринт 4 | Выполнил: Кожевников Я. В. | ПКТб-25-1";
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #4                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
Console.WriteLine("* Задание #5                                                                   *");
Console.WriteLine("* Вариант #13                                                                  *");
Console.WriteLine("* Выполнил: Кожевников Ярослав Вадимович | ПКТб-25-1                           *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный случайными  *");
Console.WriteLine("* значениями в диапазоне от -2 до 5. Заменить отрицательные элементы на 0.     *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");

Console.WriteLine("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов в массиве: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, colums];
Random rnd = new Random();

Console.WriteLine("********************************************************************************");
Console.WriteLine("\nМассив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        matrix[i, j] = rnd.Next(-2, 5);
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");
int[,] res = ds.Calculate(matrix);
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        Console.Write($"{res[i, j]} \t");
    }
    Console.WriteLine();
}