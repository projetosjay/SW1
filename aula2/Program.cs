namespace aula2;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //Console.ReadKey();

        //criar uma instancia (objeto) a partir de uma classe
        aula2 exe01 = new aula2();

        exe01.mostramgn();

        exe01.pegaNome("Jayane");

        Console.WriteLine(exe01.mensagem());

        Console.WriteLine(" O resultado da soma é" + exe01.somar(10,20));
        

    }

}
