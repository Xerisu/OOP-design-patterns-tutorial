using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class VectorSparse
    {
        Dictionary<int, double> fields;
        public VectorSparse(int length)
        {
            fields = new Dictionary<int, double>();
            Length = length;
        }

        private int Length { get; init; }

        public void AddValue(int index, double value)
        {
            if (index < Length && value != 0)
                fields[index] = value;
            if (index < Length && value == 0)
                fields.Remove(index);
        }
    }

    class VectorArray : IEnumerable<double>
    {
        private double[] array;

        public VectorArray(double[] values)
        {
            array = new double[values.Length];
            values.CopyTo(array, 0);
        }
        public class Iterator : IEnumerator<double>
        {
            double[] array;
            int current = -1;
            public Iterator(VectorArray vectorArray)
            {
                array = vectorArray.array;
            }

            
            public double Current => array[current];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                if(current == array.Length - 1) return false;  
                current++;
                return true;
            }

            public void Reset()
            {
                current = -1;
            }
        }
        public IEnumerator<double> GetEnumerator()
        {
            return new Iterator(this);
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class VectorRange : IEnumerable<int>
    {
        int start;
        int end;

        public VectorRange(int start, int end)
        {
            this.start = start;
            this.end = end;
        }

        public class Iterator : IEnumerator<int>
        {
            VectorRange range;
            int current;
            public Iterator(VectorRange vectorRange)
            {
                range = vectorRange;
                current = vectorRange.start - 1;
            }

            
            public int Current => current;

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                if (current == range.end) return false;
                current++;
                return true;
                
            }

            public void Reset()
            {
                current = range.start - 1;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new Iterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
