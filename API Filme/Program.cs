using API_Filme.Filtros;
using API_Filme.Modelos;
using System.Text.Json;


using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        var filmes = JsonSerializer.Deserialize<List<Filmes>>(resposta);
        LinqFilter.FiltrarFilmesPelaNota(filmes, "8.9");

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Tivemos um problema: {ex.Message}");
    }
}
