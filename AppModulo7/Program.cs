using System;
using AppModulo7.text;

namespace AppModulo7
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----Esta es una app que usa Text Analytics-----
            Console.WriteLine("Escribe texto: ");
            var texto = Console.ReadLine();
            var text = TextClient.Text;

            var result = text.DetectLanguage(texto);

            Console.WriteLine("-.-.-.Detectando idioma-.-.-.-.");
            Console.WriteLine($"idioma: {result.Value.Name}");
            Console.WriteLine($"iso-6391: {result.Value.Iso6391Name}");            
        }
    }
}
