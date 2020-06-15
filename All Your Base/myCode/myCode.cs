using System;
using System.Collections.Generic;
using System.Linq;

namespace myCode
{
    public class AllYourBase
    {
        public static int[] Rebase(int iBase, int[] theirDigits, int oBase)
        {
            if(iBase<2||oBase<2){throw new ArgumentException();}
            var myDigits = new List<double>();
            int temp=0;
            var max=theirDigits.Count();
                for(int i=0; i<max; i++)
                {
                    if(theirDigits[i]<0||theirDigits[i]>iBase-1){throw new ArgumentException();}
                    temp+=(int)(theirDigits[i]*Math.Pow(iBase,max-i-1));
                }
                while(temp>0)
                {
                    myDigits.Add(temp%oBase);
                    temp=temp/oBase;
                }
            myDigits.Reverse();
            int[] res;
            if(myDigits.Sum()==0)
            {
                res=new[] {0};
            }
            else
            {
                res=new int[myDigits.Count()];
                int j=0;
                foreach(int digit in myDigits)
                {
                    res[j]=digit;
                    j++;
                }
            }
            return res;
        }
    }
}
