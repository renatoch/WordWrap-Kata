using System;
using System.Text;

namespace KataWordWrap
{
    public class Wrapper
    {
        public static string Wrap(string input, int columns) {
            var result = new StringBuilder();

            var stringSize = input.Length;
            if (stringSize <= columns) {
                return input;
            }

            var remaining = input;

            do {
                var part = remaining.Substring(0, columns);

                remaining = remaining.Substring(columns);


                var isPartFullSentence = remaining[0] == ' ';
                if (isPartFullSentence) {
                    result.AppendLine(part);
                    remaining = remaining.Substring(1);
                } else {
                    var lastSpaceIndex = part.LastIndexOf(" ", StringComparison.Ordinal);
                    if (lastSpaceIndex <= -1) {
                        result.AppendLine(part);
                    } else {
                        result.AppendLine(part.Substring(0, lastSpaceIndex));

                        remaining = part.Substring(lastSpaceIndex + 1) + remaining;
                    }
                }

            } while (remaining.Length > columns);

            result.Append(remaining);

            return result.ToString().Replace("\r", "");

        }
    }
}


