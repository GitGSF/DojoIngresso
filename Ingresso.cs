namespace DojoIngresso
{
    public class Ingresso
    {
        // Ingresso, Classe Pai
        public float Valor { get; set; }
        public void ImprimirValor(){
            System.Console.WriteLine("O valor do bilhete é de RS"+Valor);
        }
    }
}