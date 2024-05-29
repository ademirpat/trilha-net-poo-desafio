namespace DesafioPOO.Models
{
    // Implementado : TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // Implementado : TODO: Sobrescrever o método "InstalarAplicativo"
           public Nokia(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
            {
            }

        public override void InstalarAplicativo(string nomeApp)
        {
            // Implementado :TODO: Sobrescrever o método "InstalarAplicativo"
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}