using System;
using System.Collections.Generic;

namespace myCode
{
    public static class SaddlePoints
    {
        public static IEnumerable<(int, int)> Calculate(int[,] matrix)
        {
            int h=matrix.GetLength(0);
            int l=matrix.GetLength(1);
                for(int i=0;i<h;i++){
                    for (int j=0;j<l;j++)
                    {
                        var current=matrix[i,j];
                        bool isSaddlePoint = true;
                        for (int a=0;a<h;a++)
                        {
                            if(current > matrix [a,j])
                            {
                                isSaddlePoint=false;
                            }
                        }
                        for (int b=0;b<l;b++)
                        {
                            if(current < matrix [i,b])
                            {
                                isSaddlePoint=false;
                            }
                        }
                        if(isSaddlePoint)
                        {
                          yield return (i+1,j+1);
                        }
                    }
                }
        }
    }
}