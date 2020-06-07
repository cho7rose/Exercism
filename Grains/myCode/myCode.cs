using System;
using System.Linq;

namespace myCode
{
    public class Grains
    {
        public static ulong Square(int square)
        {            
            if (square<1 || square>64)
            {
                throw new ArgumentOutOfRangeException();
            }
            return (ulong)Math.Pow(2,square-1);
        }
        public static ulong Total()
        {
            ulong t=0;
            for(int i=1;i<65;i++)
            {
                t+=Grains.Square(i);
            }
            return (ulong)t;
        }
    }
}
