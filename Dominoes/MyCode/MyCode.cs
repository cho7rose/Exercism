using System;
using System.Collections.Generic;

namespace MyCode
{
    public class Dominoes
    {
        public static bool CanChain((int, int)[] dominoes)
        {
            bool result=true;
            var MyDominoes = new List<Tuple<int, int>>();
            foreach((int, int) d in dominoes)
            {
                MyDominoes.Add(new Tuple<int, int>(d.Item1, d.Item2));
            }
            if(MyDominoes.Count==0) result=true;
            else if(MyDominoes.Count==1) 
            {
                result = (MyDominoes[0].Item1==MyDominoes[0].Item2)?true:false;
            }
            else
            {
                int ToF1=MyDominoes[0].Item1;
                int ToF2=MyDominoes[0].Item2;
                MyDominoes.Remove(MyDominoes[0]);
                result=CheckChain(ToF1, MyDominoes);
                if(result==false)
                    result=CheckChain(ToF2, MyDominoes);
            }    
            return(result);
        }
        private static bool CheckChain(int ToF, List<Tuple<int, int>> HisDominoes)
        {
                var MyDominoes = new List<Tuple<int, int>>();
                foreach(var d in HisDominoes)
                {
                    MyDominoes.Add(new Tuple<int, int>(d.Item1, d.Item2));
                }
                bool match=true;
                while(MyDominoes.Count!=0&&match==true)
                {
                    match=false;
                    foreach(var d in MyDominoes)
                    {
                        if(d.Item1.Equals(ToF))
                        {
                            ToF=d.Item2;
                            match=true;
                            MyDominoes.Remove(d);
                            break;
                        }
                        else
                        {
                            if(d.Item2.Equals(ToF))
                            {
                                ToF=d.Item1;
                                match=true;
                                MyDominoes.Remove(d);
                                break;
                            }
                        }
                    }
                }
                return(match);
        }
    }
}
