using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace MvcApiCall.Models
{
  public class Weather
  {
    public string Temp { get; set; }
    public string Humidity { get; set;}

    public static List<Weather> GetWeather(string apiKey2)
    {
      var apiCallTask = ApiHelper2.ApiCall2(apiKey2);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Weather> weatherList = JsonConvert.DeserializeObject<List<Weather>>(jsonResponse["results"].ToString());

      return weatherList;
    }
  }
}