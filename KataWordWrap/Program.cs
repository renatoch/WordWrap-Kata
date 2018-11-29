using System;

namespace KataWordWrap
{
    class Program
    {
        static void Main(string[] args) {
            var texto = "Hoje é domingo, pede cachimbo. Cachimbo é de ouro. Bate no touro.";
            var wrap = Wrapper.Wrap(texto, 14);
            Console.WriteLine(wrap);
        }
    }
}
