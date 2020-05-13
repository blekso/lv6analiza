using System;
using System.Collections.Generic;
using System.Text;

namespace lv6.components
{
    //2.zad
    interface IIterator
    {
        Product First();
        Product Next();
        bool IsDone { get; }
        Product Current { get; }
    }
}
