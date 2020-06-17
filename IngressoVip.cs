namespace DojoIngresso
{
    public class IngressoVip : Ingresso
    {
        // 
        //
        public float ValorAdicional {get; set; }

        public void MostrarValorVip(){
            float PrecoTotal = Valor + ValorAdicional;
            System.Console.WriteLine($"Valor do Ingresso VIP é R${PrecoTotal}");
        }
    }
}