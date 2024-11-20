using Tyuiu.AlshinAF.Sprint4.Task1.V11.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #4 | Выполнил: Альшин А. Ф. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема:  Одномерные массивы (ввод c клавиатуры)                           *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #11                                                             *");
Console.WriteLine("* Выполнил: Альшин Артур Фаритович | РППб-24-1                            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 17 элементов заполненный         *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 6 подсчитать сумму          *");
Console.WriteLine("* четных элементов массива.  С клавиатуры:                                *");
Console.WriteLine("*2, 6, 5, 5, 1, 5, 6, 5, 5, 5, 1, 5, 3, 6, 6, 1, 6                        *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int len;
Console.WriteLine("Введите количество элементов массива: ");
len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
for (int i = 0; i <= len-1; i++)
{
    Console.Write("Введите значение " + i + " элемента массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0;i <= len-1;i++)
{
    Console.WriteLine(array[i] + "\t");
}    
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(ds.Calculate(array));
Console.ReadKey();