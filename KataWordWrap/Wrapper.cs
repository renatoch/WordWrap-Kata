using System;
using System.Text;

namespace KataWordWrap
{
    public class Wrapper
    {
        public static string Wrap(string input, int columns) {
            var stringSize = input.Length;
            if (stringSize > columns) {
                var lastSpaceIndex = input.LastIndexOf(" ", StringComparison.Ordinal);
                if (lastSpaceIndex > -1) {
                    return new StringBuilder(input) {[lastSpaceIndex] = '\n'}.ToString();
                }
                return input.Insert(columns, "\n");
            }
            return input;
        }
    }
}
