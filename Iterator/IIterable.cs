using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    interface IIterable<T>
    {
        IIterator<T> GetIterator();
    }

    interface IIterator<T>
    {
        T Current { get; }
        bool MoveNext();
        void Reset();

    }
}
