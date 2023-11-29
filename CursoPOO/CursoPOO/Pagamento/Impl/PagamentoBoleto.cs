using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOO.Pagamento.Impl
{
    public class PagamentoBoleto : IPagamento
    {
        public void Processar(Cesta cesta)
        {
            Console.WriteLine($"Gerando boleto da cesta no valor total de: {cesta.ValorTotalFormatado}");
            Console.WriteLine("Pagamento com boleto realizado com sucesso!");
        }
    }
}
