using System;
using System.Collections.Generic;
using System.Text;

namespace myproject.TwoDArray
{
    class RowAverage
    {
        public static void rowWiseAvg(int[,]inputArray)
        {
            int rows = inputArray.GetLength(0);
            int colm = inputArray.GetLength(1);
            for(int i=0;i<rows;i++)
            {
                float rowAvg = 0;
                for(int x=0;x<colm;x++)
                {
                    rowAvg += inputArray[i, x];
                }
                rowAvg = rowAvg / colm;
                Console.Write("Average of Row{0} is :{1}", i, rowAvg);
            }
        }
    }
}
