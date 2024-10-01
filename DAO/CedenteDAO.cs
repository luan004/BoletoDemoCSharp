using System.Text.Json;
using System.Text.Json.Nodes;

namespace BoletoDemoCSharp;

public class CedenteDAO
{
    Cedente cedente;

    public CedenteDAO(Cedente cedente)
    {
        this.cedente = cedente;
    }

    public CreateCedente()
    {
        // Create Cedente

        var values = new Dictionary<string, string>
        {
            { "CedenteRazaoSocial", this.cedente.RazaoSocial },
            { "CedenteNomeFantasia", cedente.NomeFantasia },
            { "CedenteCPFCNPJ", cedente.CpfCnpj },
            { "CedenteEnderecoLogradouro", cedente.EnderecoLogradouro },
            { "CedenteEnderecoNumero", cedente.EnderecoNumero },
            { "CedenteEnderecoComplemento", cedente.EnderecoComplemento },
            { "CedenteEnderecoBairro", cedente.EnderecoBairro },
            { "CedenteEnderecoCEP", cedente.EnderecoCep },
            { "CedenteEnderecoCidadeIBGE", cedente.EnderecoCidadeIbge.ToString() },
            { "CedenteTelefone", cedente.Telefone },
            { "CedenteEmail", cedente.Email }
        };

        // json body

        var json = JsonSerializer.Serialize(values);

        // request

        var client = new HttpClient();

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri("https://api.boletobancario.com/cedentes"),
            Content = new StringContent(json, Encoding.UTF8, "application/json")
        };

        var response = await client.SendAsync(request);

        // response

        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine("Cedente criado com sucesso");
        }
        else
        {
            Console.WriteLine("Erro ao criar cedente");
        }

        
    }

    public UpdateCedente()
    {
        // Update Cedente
    }

    public GetCedente()
    {
        // Get Cedente
    }

}