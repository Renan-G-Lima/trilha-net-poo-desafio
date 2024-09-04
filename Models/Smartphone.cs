namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama,
        private string Modelo { get; set; }
        private sbyte IMEI { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero)
        {
            Numero = numero;
        }
        public Smartphone(string numero, string modelo, sbyte imei, int memoria)
        {
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}