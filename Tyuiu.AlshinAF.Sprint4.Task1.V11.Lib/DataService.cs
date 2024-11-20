﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AlshinAF.Sprint4.Task1.V11.Lib
{
    public class DataService : ISprint4Task1V11
    {
        public int Calculate(int[] array)
        {
            int sumArray = 0;
            for (int i = 0; i <= array.Length -1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sumArray = sumArray + array[i];
                }
             
            }
            return sumArray;
        }
    }
}