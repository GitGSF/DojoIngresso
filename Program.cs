using System;

namespace DojoIngresso
{

    class Program

    {
        static void Main(string[] args)
        {
            Ingresso bilhete = new Ingresso();
            IngressoVip vip = new IngressoVip();
            vip.Valor = 25f;
            vip.ValorAdicional = 10.50f;

            vip.MostrarValorVip();
            System.Console.WriteLine($"A diferença dos bilhetes normal e VIP são de R$ {vip.ValorAdicional}");
            
        }
    }
}
