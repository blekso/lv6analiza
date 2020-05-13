using System;
using System.Collections.Generic;
using System.Text;

namespace lv6.components
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
