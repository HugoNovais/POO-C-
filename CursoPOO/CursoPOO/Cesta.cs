using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOO
{
    internal class Cesta
    {
        public List<Item> Itens { get; set; }

        public Cesta() 
        { 
         Itens = new List<Item>();
        }
    }
}
