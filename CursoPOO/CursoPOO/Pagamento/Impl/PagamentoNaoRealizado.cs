using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOO.Pagamento.Impl
{
    internal class PagamentoNaoRealizado : IPagamento
    {
        public void Processar(Cesta cesta)
        {
            Console.WriteLine("Pagamento não realizado");
        }
    }
}
