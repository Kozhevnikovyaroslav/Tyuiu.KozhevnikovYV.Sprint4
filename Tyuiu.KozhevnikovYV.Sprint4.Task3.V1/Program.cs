using Tyuiu.KozhevnikovYV.Sprint4.Task3.V1.Lib;
DataService ds = new DataService();

Console.Title = "Спринт 4 | Выполнил: Кожевников Я. В. | ПКТб-25-1";
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #4                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
Console.WriteLine("* Задание #3                                                                   *");
Console.WriteLine("* Вариант #1                                                                   *");
Console.WriteLine("* Выполнил: Кожевников Ярослав Вадимович | ПКТб-25-1                           *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный             *");
Console.WriteLine("* значениями в диапазоне от 1 до 9. Найдите сумму элементов в последнем столбце*");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");

int[,] array = new int[5, 5] { { 3, 4, 3, 4, 1 },
                               { 8, 1, 6, 6, 9 },
                               { 9, 8, 5, 1, 3 },
                               { 1, 8, 7, 1, 2 },
                               { 9, 9, 7, 5, 6 } };
int rows = array.GetLength(0);
int col = array.GetLength(1);
int lastCol = array.GetLength(1) - 1;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < col; j++)
    {
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");
Console.WriteLine(ds.Calculate(array));