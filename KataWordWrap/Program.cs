using System;

namespace KataWordWrap
{
    class Program
    {
        static void Main(string[] args) {
            var columns = 15;
            Console.WriteLine(new String(' ', columns - 1) + "|");
            var texto = "Hoje é domingo, pede cachimbo. Cachimbo é de ouro. Bate no touro.";
            var wrap = Wrapper.Wrap(texto, columns);
            Console.WriteLine(wrap);
        }
    }
}
