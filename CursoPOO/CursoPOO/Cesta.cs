﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOO
{
    public class Cesta
    {
        private IList<Item> _itens;

        public IEnumerable<Item> Itens
        {
            get { return _itens.AsEnumerable(); }
        }

        public int TotalItens => _itens.Sum(x => x.Quantidade);

        public decimal ValorTotal => _itens.Sum(x => x.Total);

        public string ValorTotalFormatado => ValorTotal.ToString("C");

        public void AdicionarItem(Item item)
        {
            if (item == null)
            {
                throw new ArgumentException("item");
            }

            _itens.Add(item);
        }

        public void RemoverItem(Item item)
        {
            _itens.Remove(item);
        }

        public override string ToString()
        {
            return $"Qtd Itens: {TotalItens} | Total: {ValorTotalFormatado}";
        }

        public Cesta()
        {
            _itens = new List<Item>();
        }
    }
}

