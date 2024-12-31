using System.Net;
using RestSharp;
using DotNetEnv;

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
    
    public void Create()
    {
        Env.Load();

        
        string url = Env.GetString("API_URL");

        if (url == null)
        {
            Console.WriteLine("ERROR: API_URL não encontrado no arquvio .env");
            return;
        }

        Console.WriteLine("API_URL: " + url);

        var client = new RestClient(url);

        var request = new RestRequest(
            "/cedentes",
            Method.Post
        ).AddHeader(
            "Content-Type", "application/json"
        ).AddJsonBody(new {
            CedenteRazaoSocial = RazaoSocial,
            CedenteNomeFantasia = NomeFantasia,
            CedenteCPFCNPJ = CpfCnpj,
            CedenteEnderecoLogradouro = EnderecoLogradouro,
            CedenteEnderecoNumero = EnderecoNumero,
            CedenteEnderecoComplemento = EnderecoComplemento,
            CedenteEnderecoBairro = EnderecoBairro,
            CedenteEnderecoCEP = EnderecoCep,
            CedenteEnderecoCidadeIBGE = EnderecoCidadeIbge,
            CedenteTelefone = Telefone,
            CedenteEmail = Email
        });

        var response = client.Execute(request);

        if (response.StatusCode != HttpStatusCode.OK)
        {
            Console.WriteLine("ERROR: " + response.Content);
            return;
        } else {
            Console.WriteLine("Cedente criado com sucesso!");
            Console.WriteLine(response.Content);
        }
    }
}