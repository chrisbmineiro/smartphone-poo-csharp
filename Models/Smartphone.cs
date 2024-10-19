namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected string Numero { get; }
        protected string Modelo { get; }
        protected string Imei { get; }
        protected int Memoria { get; }
        // Permite ter 2 opções instanciar vazio o com os valores descritos
        public Smartphone()
        {
            
        }
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar(int numero)
        {
            Console.WriteLine($"Ligando para {numero}... ");
        }

        public void ReceberLigacao(int numero)
        {
            Console.WriteLine($"Recebendo ligação de {numero}...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}