using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOO.Pagamento.Impl
{
    internal class PagamentoCartaoCredito : IPagamento
    {
        public void Processar(Cesta cesta)
        {
            Console.WriteLine($"Realizando o pagamento da cesta no valor total de: {cesta.ValorTotalFormatado}");
            Console.WriteLine("Pagamento com cartão de crédito realizado com sucesso!");
        }
    }
}
