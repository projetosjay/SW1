namespace Exemplo_heranca;
class FuncionarioN1: Funcionario
{


public virtual double participacao(){
    return base.participacao()*0.01;
}
}
