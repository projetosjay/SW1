namespace exercicio_contrato;
class Program
{
    static void Main(string[] args)
    {
      PFisica fisica = new PFisica();
      Pjuridica juridica = new Pjuridica();
      Contrato contrato = new Contrato();  

    fisica.Nome = "jayane";
    fisica.Email = "jayane@gmail.com";
    fisica.Telefone= 40028922 ;

    juridica.Nome = "jayane02";
    juridica.Email ="santosjayane@gmail.com";
    juridica.Telefone = 123456789;


      Console.WriteLine(" Seu contrato é: " + fisica.MostraDados());
      Console.WriteLine(" Seu cpf: " + fisica.Cpf );
      Console.WriteLine(" Seu Email: " + fisica.Email);
      Console.WriteLine(" Sua idade: "+ fisica.idade);

      Console.WriteLine( " Seu contrato é: " + juridica.MostraDados()); 
      Console.WriteLine(" Seu cnpj: " + juridica.cnpj );
      Console.WriteLine(" Seu IE: " + juridica.ie);
      Console.WriteLine(" O nome da sua empresa é: " + juridica.NomeEmpresa);


    }
}
