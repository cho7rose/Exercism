using System;

namespace Coding
{
    
    class Clock
    {
        int _hours, _minutes;
        public Clock(int Hours, int Minutes)
        {
           //_hours=(Hours%24+(Minutes/60)+24)%24;
           _minutes=(Minutes%60+60)%60;
           int total=((Hours*60+Minutes)%1440+1440)%1440;
           _hours=total/60;

        }

        public override string ToString()
        {
            return($"{_hours:D2}:{_minutes:D2}");
        }


    }
    class Program
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Hello Vincent");
        }*/
    }
}