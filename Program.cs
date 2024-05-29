using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teste com a classe Iphone
            Smartphone meuIphone = new Iphone("123456789", "iPhone 13", "ABCDE12345", 128);
            meuIphone.Ligar();
            meuIphone.ReceberLigacao();
            meuIphone.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            // Teste com a classe Nokia
            Smartphone meuNokia = new Nokia("987654321", "Nokia 3310", "FGHIJ67890", 16);
            meuNokia.Ligar();
            meuNokia.ReceberLigacao();
            meuNokia.InstalarAplicativo("Snake");

            Console.WriteLine("Testes finalizados.");
        }
    }
}