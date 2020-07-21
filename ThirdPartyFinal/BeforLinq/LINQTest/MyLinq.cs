using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LINQTest
{
    public static class MyLinq
    {

        public static int Count(this IEnumerable enumerable)
        {
            var enumerator= enumerable.GetEnumerator();
            int TotalCount=0;
            while (enumerator.MoveNext())
            {
                TotalCount ++;
               

            }
            return TotalCount;
        }


        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> input,Func<T,bool> ex )
        {
            List<T> result = new List<T>();
            foreach (var item in input)
            {
                
                if (ex.Invoke(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        
   public static IEnumerable<T> MyWhere1<T>(this IEnumerable<T> input, Func<T, bool> ex)
        {
            foreach (var item in input)
            {

                if (ex.Invoke(item))
                {
                    yield return item;
                }
            }
          
        }
    }
}
