using System.Text.Json.Serialization;

namespace API_Filme.Modelos;

internal class Filmes
{
    [JsonPropertyName("title")]
    public string Titulo { get; set; }
    [JsonPropertyName ("imDbRating")]
    public string Nota { get; set; }
    [JsonPropertyName("year")]
    public string Ano { get; set; }

    public void ExibirDetalhesDoFilme()
    {
        Console.WriteLine($"Filme : {Titulo}");
        Console.WriteLine($"Ano de lançamento  : {Ano}");
        Console.WriteLine($"Nota do filme : {Nota}");
    }
}
