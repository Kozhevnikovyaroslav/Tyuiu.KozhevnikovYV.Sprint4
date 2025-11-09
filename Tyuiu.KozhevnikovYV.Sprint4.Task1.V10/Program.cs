using System.ComponentModel.DataAnnotations;
using Tyuiu.KozhevnikovYV.Sprint4.Task1.V10.Lib;
DataService ds = new DataService();

Console.Title = "Спринт 4 | Выполнил: Кожевников Я. В. | ПКТб-25-1";
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #4                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
Console.WriteLine("* Задание #1                                                                   *");
Console.WriteLine("* Вариант #10                                                                  *");
Console.WriteLine("* Выполнил: Кожевников Ярослав Вадимович | ПКТб-25-1                           *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* подсчитать произведение нечетных элементов массива.                          *");
Console.WriteLine("* С клавиатуры: 5, 6, 8, 3, 5, 2, 4, 4, 1, 3, 5                                *");
Console.WriteLine("*                                                                              *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");

int len;
Console.WriteLine("Введите количество элементов массива:");
len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];

for ( int i = 0; i <= len-1; i++)
{
    Console.WriteLine("Введите значение " + i + " элемента массива");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i] + "\t");
}
Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");
Console.WriteLine(ds.Calculate(array));