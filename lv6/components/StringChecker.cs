using System;
using System.Collections.Generic;
using System.Text;

namespace lv6.components
{
    abstract class StringChecker
    {
        private StringChecker next;
        private string stringToCheck;

        public void Set(StringChecker next, string stringToCheck)
        {
            this.next = next;
            this.stringToCheck = stringToCheck;
        }
        public bool Check(string stringToCheck)
        {
            bool result = this.PerformCheck(stringToCheck);
            if (this.next != null && result == true)
            {
                return this.next.Check(stringToCheck);
            }
            return result;
        }
        protected abstract bool PerformCheck(string stringToCheck);
    }
}
