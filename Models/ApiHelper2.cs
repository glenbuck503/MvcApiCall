using System.Threading.Tasks;
using RestSharp;

namespace MvcApiCall.Models
{
  class ApiHelper2
  {
    public static async Task<string> ApiCall2(string apiKey2)
    {
      RestClient client = new RestClient("api.openweathermap.org/data/2.5/");
      RestRequest request = new RestRequest($"home.json?api-key={apiKey2}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    
  }
}

// first api call from times. use ase test

// public static async Task<string> ApiCall2(string apiKey2)
//     {
//       RestClient client = new RestClient("https://api.nytimes.com/svc/topstories/v2");
//       RestRequest request = new RestRequest($"home.json?api-key={apiKey2}", Method.GET);
//       var response = await client.ExecuteTaskAsync(request);
//       return response.Content;
//     }



