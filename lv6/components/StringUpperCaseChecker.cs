using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lv6.components
{
    class StringUpperCaseChecker : StringChecker
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
            return stringToCheck.Any(char.IsUpper);
        }
    }
}
