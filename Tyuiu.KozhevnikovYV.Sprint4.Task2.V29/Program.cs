using Tyuiu.KozhevnikovYV.Sprint4.Task2.V29.Lib;
DataService ds = new DataService();

Console.Title = "Спринт 4 | Выполнил: Кожевников Я. В. | ПКТб-25-1";
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #4                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
Console.WriteLine("* Задание #2                                                                   *");
Console.WriteLine("* Вариант #29                                                                  *");
Console.WriteLine("* Выполнил: Кожевников Ярослав Вадимович | ПКТб-25-1                           *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* подсчитать произведение четных элементов массива.                            *");
Console.WriteLine("*                                                                              *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");

Random rnd = new Random();
int len;
Console.WriteLine("Введите количество индексов у массива: ");
len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
for (int i = 0; i <= len-1; i++)
{
    array[i] = rnd.Next(1, 8);
}
for (int i = 0; i <= len - 1; i++)
{
    Console.WriteLine(array[i] + "\t");
}
Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");
Console.WriteLine(ds.Calculate(array));