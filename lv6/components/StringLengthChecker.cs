using System;
using System.Collections.Generic;
using System.Text;

namespace lv6.components
{
    class StringLengthChecker : StringChecker
    {
        private StringChecker next;
        private string stringToCheck;

        public void Set(StringChecker next, string stringToCheck)
        {
            this.next = next;
            this.stringToCheck = stringToCheck;
        }
        protected override bool PerformCheck(string stringToCheck)
        {
            int lenght = stringToCheck.Length;
            if (lenght > 0)
            {
                return true;
            }
            return false;
        }
    }
}
