using Tyuiu.KozhevnikovYV.Sprint4.Task7.V2.Lib;
DataService ds = new DataService();

Console.Title = "Спринт 4 | Выполнил: Кожевников Я. В. | ПКТб-25-1";
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #4                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
Console.WriteLine("* Задание #7                                                                   *");
Console.WriteLine("* Вариант #2                                                                   *");
Console.WriteLine("* Выполнил: Кожевников Ярослав Вадимович | ПКТб-25-1                           *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* Дана строка из одноразрядных цифр 597643158942. Преобразуйте ее в матрицу    *");
Console.WriteLine("* 3 на 4 и подсчитайте сумму нечетных чисел.                                   *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");

int n = 3;
int m = 4;
int[,] matrix = new int[n, m];
string str = "597643158942";
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = int.Parse(str.Substring(i * m + j, 1));
    }

}
Console.WriteLine("Матрица: ");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}


Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");
int res = ds.Calculate(n, m, str);
Console.WriteLine(res);