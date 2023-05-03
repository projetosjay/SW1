namespace Exemplo_heranca;
class FuncionarioN2:Funcionario
{

public override double participacao(){
    return base.participacao()*0.02;
}
}
