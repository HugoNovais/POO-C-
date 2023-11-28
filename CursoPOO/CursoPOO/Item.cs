using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoPOO
{
    public class Item
    {
       
        private int _quantidade;
        private decimal _preco;

        private const int QUANTIDADE_CARRINHO = 1;
        public string Nome { get; set; }
        public int Quantidade
        {
            get { return _quantidade; }
            set
            {
                if (value > 0)
                {
                    _quantidade = value;
                }
            }
        }
        public decimal Preco
        {
            get { return _preco; }
            set
            {
                if (value > 0)
                {
                    _preco = value;
                }

            }
        }

        public Item()
        {
            _quantidade = QUANTIDADE_CARRINHO;
            
        }

        public decimal Total
        {
            get { return Preco * Quantidade; }
        }

        public string TotalFormatado => Total.ToString("C"); //Currency (moeda)

        public Item(string nome, decimal preco) : base()
        {
            Nome = nome;
            _preco = preco;
            _quantidade = QUANTIDADE_CARRINHO;
        }

        //Está vinculado a classe
        public static Item CriarCar()
        {
            var bola = new Item();
            bola.Nome = "Bola de basquete";
            bola.Quantidade = 1;
            bola._preco = 50M;

            return bola;
        }

     

        /*get { return _nome; }
        set {
            if (String.IsNullOrEmpty(value))
            { throw new ArgumentNullException("Nome vazio!"); }
            _nome = value; 
        }*/




        /* public string getNome()
         { 
             return _nome;
         }

         public void setNome(string nome)
         { 
             if (String.IsNullOrEmpty(nome))
             {  throw new ArgumentNullException("Nome vazio!")  ; }
          this._nome = nome;
         }*/
    }
}
