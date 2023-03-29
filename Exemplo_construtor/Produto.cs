namespace Exemplo_construtor;
class Produto
{
   public Produto(){
    this.Nome = "XTPO";
    this.Preco = 1;
   }

      public Produto(double preco){
    this.Nome = "NÃO INFORMADO";
    this.Preco = preco;
   }

      public Produto(String nome, double desconto){
    this.Nome = nome;
    this.Preco = 10- 10*desconto/100;
   }

public string? Nome{get;set;}

public double Preco{get;set;}

public void mostraDados(){
    Console.WriteLine("Nome: " + this.Nome);
    Console.WriteLine("Preço: " + this.Preco);

}

public void AlteraPreco(double preco){
    if(preco >= 0){
            this.Preco = preco;
    }
    else{
        Console.WriteLine ("VALOR INVÁLIDO");
        }

}
public void AlteraNome(string nome){
    this.Nome = nome;

}
}
