namespace BoletoDemoCSharp;

class Program
{
    static void Main(string[] args)
    {
        Cedente cedente = new Cedente(
            "Razao Social",
            "Nome Fantasia",
            "CpfCnpj",
            "Endereco Logradouro",
            "Endereco Numero",
            "Endereco Complemento",
            "Endereco Bairro",
            "Endereco Cep",
            123456,
            "Telefone",
            "Email"
        );

        cedente.Create();
        
    }
}