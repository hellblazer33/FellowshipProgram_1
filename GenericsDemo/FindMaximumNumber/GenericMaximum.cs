using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaximumNumber
{
    class GenericMaximum<T> where T:IComparable
    {
        public T[] value;
        public GenericMaximum(T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(params T[] values)
        {
            var sorted_values = Sort(values);   //any data type is var variable
            return sorted_values[sorted_values.Length - 1];
        }
        public T MaxValueSecond(params T[] values)
        {
            var sorted_values2 = Sort(values);   //any data type is var variable
            return sorted_values2[sorted_values2.Length - 2];
        }

        public T MaxValueThird(params T[] values)
        {
            var sorted_values3 = Sort(values);   //any data type is var variable
            return sorted_values3[sorted_values3.Length - 2];
        }


        public T MaxMethod()
        {
            var max = MaxValue(this.value);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = MaxValue(this.value);
            var max2 = MaxValueSecond(this.value);
            var max3 = MaxValueThird(this.value);
            Console.WriteLine("Maximum value is " + max);
            Console.WriteLine("2nd Maximum value is " + max2);
            Console.WriteLine("3rd Maximum value is " + max3);

        }
    }
}
