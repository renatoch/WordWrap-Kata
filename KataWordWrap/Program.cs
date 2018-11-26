using System;

namespace KataWordWrap
{
    class Program
    {
        static void Main(string[] args) {
            var texto = "Hoje é domingo, pede cachimbo. E uma outra expressão qualquer";
            var wrap = Wrapper.Wrap(texto, 5);
            Console.WriteLine(wrap);
        }
    }
}
