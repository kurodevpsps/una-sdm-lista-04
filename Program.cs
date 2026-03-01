using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

using HttpClient client = new();

try 
{
    string response = await client.GetStringAsync("https://api.adviceslip.com/advice");
    using JsonDocument doc = JsonDocument.Parse(response);
    string advice = doc.RootElement.GetProperty("slip").GetProperty("advice").GetString();
    
    Console.WriteLine("Conselho de Hoje:");
    Console.WriteLine(advice);
}
catch (Exception ex)
{
    Console.WriteLine($"Erro ao buscar conselho: {ex.Message}");
}