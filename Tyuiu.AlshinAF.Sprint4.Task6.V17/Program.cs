using Tyuiu.AlshinAF.Sprint4.Task6.V17.Lib;
DataService ds = new DataService();
Random rnd = new Random();
Console.Title = "Спринт #4 | Выполнил: Альшин А. Ф. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема:  Двумерные массивы. (генератор случайных чисел)                   *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #17                                                             *");
Console.WriteLine("* Выполнил: Альшин Артур Фаритович | РППб-24-1                            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан строковый массив данных используя класс Array подсчитайте количество*");
Console.WriteLine("* элементов, длина которых равна 6                                        *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
var progr = new string[] { "Python", "JavaScript", "Java", "C#", "Swift", "Kotlin", "Ruby" };
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < progr.Length; i++)
{
    Console.WriteLine(progr[i]);
}


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Количество элементов длина которых = 6: " + ds.Calculate(progr));
Console.ReadKey();