using System;
using System.Collections.Generic;


namespace DBLinked_Lists
{
    public class Deque<T>
      {
          private LinkedList<T> MyList;

          public Deque()
          {
            MyList = new LinkedList<T>();
          }

          public void Push(T Value)
          {
            MyList.AddLast(Value);
          }
          public T Pop()
          {
            var toto=MyList.Last.Value;
            MyList.RemoveLast();
            return(toto);
          }
          public void Unshift(T Value)
          {
            MyList.AddFirst(Value);
          }
          public T Shift()
          {
            var toto=MyList.First.Value;
            MyList.RemoveFirst();
            return(toto);
          }

      }
}
