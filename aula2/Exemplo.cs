namespace aula2;
class aula2
{
    //ATRIBUTOS
    public string nome ="";
    public int idade =0;
    public bool vacinado =false;

    //METODOS
    public void mostramgn(){
        Console.WriteLine("OIee 2F");
    }
    
    public void pegaNome(string texto){
                Console.WriteLine("OIee:" + texto);

    }

    public string mensagem(){
        return "Devolvenddo um texto";
    }

    public int somar(int a, int b){
        return a+b;
    }
}