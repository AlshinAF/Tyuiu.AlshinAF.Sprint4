﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.AlshinAF.Sprint4.Task0.V25.Lib
{
    public class DataService : ISprint4Task0V25
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int sumArray = 0;
            for (int i = 0; i< array.Length; i++)
            {
                
                if (array[i] % 2 ==0)
                {
                    int x = array[i];
                    sumArray = sumArray + x;
                }    

            }
            return sumArray;
        }
    }
}
