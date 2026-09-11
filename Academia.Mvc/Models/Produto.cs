namespace Academia;

public class Produto
{
    public int Id {get; set;}
    public string Nome {get; set;} = string.Empty; //Nome do produto (ex: Whey, Creatina, Squeeze, Trembolona)
    public decimal Preco {get; set;} // Preço do produto
    public int Estoque {get; set;} // Quantidade em estoque do produto
}