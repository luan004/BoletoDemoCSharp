namespace BoletoDemoCSharp;

class Program
{
    static void Main(string[] args)
    {
        Cedente cedente = new Cedente();
        cedente.RazaoSocial = "Razao Social";
        cedente.NomeFantasia = "Nome Fantasia";

        Console.WriteLine(cedente.RazaoSocial);

        Console.WriteLine("Hello, World!");
    }
}