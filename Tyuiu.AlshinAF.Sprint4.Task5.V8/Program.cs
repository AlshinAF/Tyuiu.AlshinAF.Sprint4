using Tyuiu.AlshinAF.Sprint4.Task5.V8.Lib;
DataService ds = new DataService();
Random rnd = new Random();
Console.Title = "Спринт #4 | Выполнил: Альшин А. Ф. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема:  Двумерные массивы. (генератор случайных чисел)                   *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #8                                                              *");
Console.WriteLine("* Выполнил: Альшин Артур Фаритович | РППб-24-1                            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* случайными значениями в диапазоне от -3 до 4. Заменить отрицательные    *");
Console.WriteLine("* элементы на 0                                                           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int colums = Convert.ToInt32(Console.ReadLine());
int[,] mtrx = new int[rows, colums];
Console.WriteLine("Массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        mtrx[i, j] = rnd.Next(-3, 4);

    }
}
Console.WriteLine("\nМассив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < colums; j++)
    {
        Console.Write($"{mtrx[i, j]} \t");
    }
    Console.WriteLine();

}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Сумма нечётных элементов = " + ds.Calculate(mtrx));
Console.ReadKey();