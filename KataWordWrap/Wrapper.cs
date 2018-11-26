using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KataWordWrap
{
    public class Wrapper
    {
        public static string Wrap(string input, int columns) {
            var stringSize = input.Length;
            if (stringSize > columns) {
                if (input.IndexOf(" ", StringComparison.Ordinal) > 0) {
                    return input.Replace(" ", "\n");
                }
                return input.Insert(columns, "\n");
            }
            return input;
        }
    }
}
