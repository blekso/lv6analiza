using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lv6.components
{
    class StringLowerCaseChecker : StringChecker
    {
        private string stringToCheck;

        public void Set(string stringToCheck)
        {
            this.stringToCheck = stringToCheck;
        }

        protected override bool PerformCheck(string stringToCheck)
        {
            return stringToCheck.Any(char.IsLower);
        }
    }
}
