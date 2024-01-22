using API_Filme.Modelos;
using System.Text.Json;


namespace API_Filme.Filtros;

internal class LinqFilter
{
    public static void FiltrarFilmesPelaNota(List<Filmes> filmes, string nota)
    {
        var filmesFiltrados = filmes.Where(filmes => filmes.Nota == nota).ToList();
        Console.WriteLine($"Exibindo os filmes com nota igual ou superior a {nota}\n\n");
        foreach( var filme in filmesFiltrados)
        {
            Console.WriteLine($"Título: {filme.Titulo}\nAno: {filme.Ano}\n\n");

        }
    }
}

