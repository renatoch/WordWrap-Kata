using System;
using System.Text;

namespace KataWordWrap
{
    public class Wrapper
    {
        public static string Wrap(string input, int columns) {
            var finalStringBuilder = new StringBuilder();
            
            var stringSize = input.Length;
            if (stringSize > columns) {

                var part = input.Substring(0, columns);

                var remaining = input.Substring(columns);

                var lastSpaceIndex = part.LastIndexOf(" ", StringComparison.Ordinal);

                if (lastSpaceIndex <= -1) {
                    return input.Insert(columns, "\n");
                }

                var firstSplit = part.Substring(0, lastSpaceIndex);
                var remainingSubPart = part.Substring(lastSpaceIndex + 1);
                return firstSplit + "\n" + remainingSubPart + remaining;

            }
            return input;
        }
    }
}


