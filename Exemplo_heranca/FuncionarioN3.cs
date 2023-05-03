namespace Exemplo_heranca;
class FuncionarioN3:Funcionario
{

public string? cargo {get;set;}
public override double participacao(){
    return base.participacao()*0.03;
}
}
