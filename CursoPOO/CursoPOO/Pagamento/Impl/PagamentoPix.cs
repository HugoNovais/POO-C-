using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOO.Pagamento.Impl
{
    internal class PagamentoPix : IPagamento
    {
        public void Processar(Cesta cesta)
        {
            Console.WriteLine($"Gerando PIX da cesta no valor total de: {cesta.ValorTotalFormatado}");
            Console.WriteLine("Pagamento com PIX realizado com sucesso!");
        }
    }
}
