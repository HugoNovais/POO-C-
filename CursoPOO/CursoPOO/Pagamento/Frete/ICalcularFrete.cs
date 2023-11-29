using CursoPOO.Frete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOO.Pagamento.Frete
{
    public interface ICalcularFrete
    {
        OpcaoFrete Calcular(Cesta cesta);
    }
}
