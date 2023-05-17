namespace exercicio_contrato;
class Contrato
{
   public virtual string? Nome{get;set;}

    public virtual string? Email {get; set;}

    public virtual string? Telefone {get; set;}

    public virtual string? MostraDados(){
        return this.Nome + this.Email + this.Telefone;
    }
   
   
}