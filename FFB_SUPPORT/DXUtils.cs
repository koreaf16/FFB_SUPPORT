﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FFB_SUPPORT
{
    public class StringIntsComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            var digitsRegex = new Regex("(\\d+)");

            // run the regex on both strings
            var xRegexResult = digitsRegex.Match(x);
            var yRegexResult = digitsRegex.Match(y);

            // check if they are both numbers
            if (xRegexResult.Success && yRegexResult.Success)
            {
                return int.Parse(xRegexResult.Groups[1].Value).CompareTo(int.Parse(yRegexResult.Groups[1].Value));
            }

            // otherwise return as string comparison
            return x.CompareTo(y);
        }
    }
}
