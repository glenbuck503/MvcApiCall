using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MvcApiCall.Models
{
  public class Book
  {
    public string Title { get; set; }
    public string Author { get; set; }

    public static List<Book> GetBooks(string apiKey)
    {
      var apiCallTask = ApiHelper.ApiCall(apiKey);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Book> bookList = JsonConvert.DeserializeObject<List<Book>>(jsonResponse["results"].ToString());

      return bookList;
    }
  }
}