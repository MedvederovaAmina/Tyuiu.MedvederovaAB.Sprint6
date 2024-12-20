﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MedvederovaAB.Sprint6.Task2.V16.Lib
{
    public class DataService : ISprint6Task2V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (Math.Cos(x) + x == 0)
                {
                    valueArray[count] = 0;
                    count++;
                    continue;
                }
                y = Math.Round((Math.Cos(x) / (x - 0.4)) + Math.Sin(x) * 8 * x + 2, 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
