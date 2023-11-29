
using CursoPOO;
using CursoPOO.Frete.Impl;
using CursoPOO.Pagamento;

/*Item carrinho = new Item();

carrinho.Nome = "Tes";
carrinho.Quantidade = 0;

Item test = Item.CriarCar();
*/
//Console.ReadLine();

/*
Cesta cesta = new Cesta();

Item bolaBasquete = new Item("Bola de Basquete", 99M);
bolaBasquete.Quantidade = 3;


Item tenis = new Item("Tenis Nike", 37);
tenis.Quantidade = 2;


foreach (var item in cesta.Itens)
{
    Console.WriteLine($"{item.Nome}: {item.TotalFormatado}");
}

Console.ReadLine();
*/

Cesta minhaCesta = new Cesta();


// Criando uma instancia da classe Item
Item bola = new Item("Bola de futebol", 89.90M, 1);
Item camiseta = new Item("Camiseta São Paulo Futebol Clube", 297.99M, 2);
Item chuteira = new Item("Chuteira Neymar", 149.99M, 1);

// Adiciona os itens na cesta

minhaCesta.AdicionarItem(bola);
minhaCesta.AdicionarItem(camiseta);
minhaCesta.AdicionarItem(chuteira);

// Imprime os valores
Console.WriteLine($"Itens da Cesta:");
foreach (Item item in minhaCesta.Itens)
{
    Console.WriteLine($"- {item}");
}
Console.WriteLine(minhaCesta);

CalcularFreteCorreios calcularFrete = SelecionarFrete.Informar();
if (calcularFrete != null)
{
    var opcaoFrete = calcularFrete.Calcular(minhaCesta);
    if (opcaoFrete != null)
    {
        Console.WriteLine($"Frete selecionado: {opcaoFrete.Nome}");
    }
    else
    {
        Console.WriteLine($"Frete não informado");
    }
}

IPagamento pagamento = SelecionarPagamento.Informar();
pagamento.Processar(minhaCesta);
Console.ReadLine();