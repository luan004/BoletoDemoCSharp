namespace BoletoDemoCSharp;

public class Cedente
{
    public string RazaoSocial {get; set;}
    public string NomeFantasia {get; set;}
    public string CpfCnpj {get; set;}
    public string EnderecoLogradouro {get; set;}
    public string EnderecoNumero {get; set;}
    public string EnderecoComplemento {get; set;}
    public string EnderecoBairro {get; set;}
    public string EnderecoCep {get; set;}
    public int EnderecoCidadeIbge {get; set;}
    public string Telefone {get; set;}
    public string Email {get; set;}


    public Cedente(string razaoSocial, string nomeFantasia, string cpfCnpj, string enderecoLogradouro, string enderecoNumero, string enderecoComplemento, string enderecoBairro, string enderecoCep, int enderecoCidadeIbge, string telefone, string email)
    {
        RazaoSocial = razaoSocial;
        NomeFantasia = nomeFantasia;
        CpfCnpj = cpfCnpj;
        EnderecoLogradouro = enderecoLogradouro;
        EnderecoNumero = enderecoNumero;
        EnderecoComplemento = enderecoComplemento;
        EnderecoBairro = enderecoBairro;
        EnderecoCep = enderecoCep;
        EnderecoCidadeIbge = enderecoCidadeIbge;
        Telefone = telefone;
        Email = email;
    }
    
    public Cedente()
    {
    }
}