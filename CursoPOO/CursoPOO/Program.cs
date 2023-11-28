
using CursoPOO;

/*Item carrinho = new Item();

carrinho.Nome = "Tes";
carrinho.Quantidade = 0;

Item test = Item.CriarCar();
*/
//Console.ReadLine();


Cesta cesta = new Cesta();

Item bolaBasquete = new Item("Bola de Basquete", 99M);
bolaBasquete.Quantidade = 3;
cesta.Itens.Add(bolaBasquete);

Item tenis = new Item("Tenis Nike", 37);
tenis.Quantidade = 2;
cesta.Itens.Add(tenis);

foreach (var item in cesta.Itens)
{
    Console.WriteLine($"{item.Nome}: {item.TotalFormatado}");
}

Console.ReadLine();