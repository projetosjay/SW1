namespace EXEMPLO_ACESSOR;
class Program
{
    static void Main(string[] args)
    {
    Produto p1 = new Produto();
    p1.AlteraPreco(50);
    p1.AlteraNome("PARAFUSO");

    p1.mostraDados();
    }
}
