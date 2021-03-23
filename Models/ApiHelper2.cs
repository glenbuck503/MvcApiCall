using System.Threading.Tasks;
using RestSharp;

namespace MvcApiCall.Models
{
  class ApiHelper2
  {
    public static async Task<string> ApiCall2(string apiKey)
    {
      RestClient client = new RestClient("https://api.nytimes.com/svc/books/v3/lists.json");
      RestRequest request = new RestRequest($"home.json?api-key={apiKey}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}