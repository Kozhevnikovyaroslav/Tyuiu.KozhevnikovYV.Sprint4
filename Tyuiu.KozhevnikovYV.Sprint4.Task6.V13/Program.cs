using Tyuiu.KozhevnikovYV.Sprint4.Task6.V13.Lib;
DataService ds = new DataService();

Console.Title = "Спринт 4 | Выполнил: Кожевников Я. В. | ПКТб-25-1";
Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #4                                                                    *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                             *");
Console.WriteLine("* Задание #6                                                                   *");
Console.WriteLine("* Вариант #13                                                                  *");
Console.WriteLine("* Выполнил: Кожевников Ярослав Вадимович | ПКТб-25-1                           *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* используя Array подсчитайте количество элементов, длина которых больше 4.    *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
Console.WriteLine("********************************************************************************");

string[] mas = new string[] { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };
for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine(mas[i] + "\t");
}
Console.WriteLine("********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
Console.WriteLine("********************************************************************************");
int res = ds.Calculate(mas);
Console.WriteLine(res);