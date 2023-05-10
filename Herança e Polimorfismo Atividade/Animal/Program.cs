namespace Animal;
class Program
{
    static void Main(string[] args)
    {
         Cachorro Dog = new Cachorro();
         Gato Cat = new Gato();
         Homem Noah = new Homem();

        Console.WriteLine("O gato faz: " + Cat.Fala());
         
         Console.WriteLine("O cachorro faz: " + Dog.Fala());
         
        Console.WriteLine("O Jayane fala: " + Noah.Fala());
    }
}
