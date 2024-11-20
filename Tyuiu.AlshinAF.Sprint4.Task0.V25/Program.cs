using Tyuiu.AlshinAF.Sprint4.Task0.V25.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнил: Альшин А. Ф. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема:  Одномерные массивы (статический ввод)                            *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #25                                                             *");
Console.WriteLine("* Выполнил: Альшин Артур Фаритович | РППб-24-1                            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать                *");
Console.WriteLine("* (сумму четных элементов массива.  {1, 4, 2, 6, 4, 8, 6, 7, 8, 4}        *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int[] array = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
Console.WriteLine("Исходный массив: ");
for (int i = 0; i <= array.Length; i++)
{
    Console.WriteLine(array[i]);
}
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(ds.GetSumEvenArrEl(array));
Console.ReadKey();