namespace Prestacao;
class Program
{
    static void Main(string[] args)
    {
        Fisica fisica = new Fisica();
        Juridica juridica = new Juridica();

       /* fisica.Detalhes(){
            fisica.idade = 12;
            fisica.cpf = 123456789;
            juridica.cnpj = 40;
            juridica.inscricao = 12;
            fisica.calcularP = 40:

        };*/
        


        Console.WriteLine("Valor da Prestação: " + juridica.calcularP() );
        Console.WriteLine();

    }
}
