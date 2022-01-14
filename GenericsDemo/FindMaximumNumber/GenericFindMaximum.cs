using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    public class GenericFindMaximum<T> where T : IComparable
    {
        T a, b, c;
        public GenericFindMaximum(T a,T b,T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public static T testMaximum(T a, T b, T c)
        {
            //15, 17, 10
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
            {
                return a;
            }
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
            {
                return b;
            }
            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0)
            {
                return c;
            }
            throw new Exception("a,b and c are same");
        }
        public T MaxMethod()
        {
            var max = testMaximum(a, b, c);
            return max;
        }
        public void printMax()
        {
            var test1 = MaxMethod();
            Console.WriteLine(test1);
        }

    }
}
