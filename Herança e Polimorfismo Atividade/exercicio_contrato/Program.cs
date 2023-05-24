namespace exercicio_contrato;
class Program
{
    static void Main(string[] args)
    {
      PFisica fisica = new PFisica();
      Pjuridica juridica = new Pjuridica();
      Contrato contrato = new Contrato();  

    fisica.Nome ="jayane";
    

      Console.WriteLine(" Seu contrato é " + fisica.MostraDados() + "Seu cpf" + fisica.Cpf + " Seu Email " + fisica.Email +" Sua idade "+ fisica.idade);
      Console.WriteLine( " Seu contrato é " + juridica.MostraDados() + " Seu cnpj " + juridica.cnpj +" Seu IE "+ juridica.ie +" O nome da sua empresa é "+ juridica.NomeEmpresa);


    }
}