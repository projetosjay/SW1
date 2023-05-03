namespace Exemplo_heranca;
class Program
{

    static void main (string[]args)
 {
FuncionarioN1 n1 = new FuncionarioN1();
FuncionarioN2 n2 = new FuncionarioN2();
FuncionarioN3 n3 = new FuncionarioN3();

n1.Nome="jayane";
n1.Idade=15;
n2.Nome="jack";
n2.Idade=43;
n3.Nome="juci";
n3.Idade=49;
n3.cargo= "gerente";


Console.WriteLine("Nome" + n1.Nome + "--idade" + n1.Idade + "--Part" + (n1.participacao()));
Console.WriteLine("Nome" + n2.Nome + "--idade" + n2.Idade + "--Part" + (n2.participacao()));
Console.WriteLine("Nome" + n3.Nome + "--idade" + n3.Idade + "--Part" + (n3.participacao()) + "--cargo" + n3.cargo);

    }
}
