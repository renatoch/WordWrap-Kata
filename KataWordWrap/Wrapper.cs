using System;
using System.Collections.Generic;
using System.Text;

namespace KataWordWrap
{
    public class Wrapper
    {
        public static string Wrap(string input, int columns) {
            var stringSize = input.Length;
            return stringSize > columns ? input.Insert(columns, "\n") : input;
        }
    }
}
