using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using apis.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
 
namespace APIConsume.Controllers
{
    public class HomeController : Controller
    {
        //[HttpGet("{id}", Name = "GetFruit")]
        public async Task<IActionResult> Index()
        {
            List<Fruit> fruits = new List<Fruit>();
          //  using (var httpClient = new HttpClient())
          //  {
               // using (var response = await httpClient.GetAsync(@"C:\Windows\apis\JsonFolder\Web.json"))
                string allText = System.IO.File.ReadAllText(@"C:\Windows\apis\JsonFolder\Web.json");

          //      {
                   // string apiResponse = await response.Content.ReadAsStringAsync();
                    fruits = JsonConvert.DeserializeObject<List<Fruit>>(allText);
                 //  _fruits = JsonConvert.DeserializeObject<List<Fruit>>(apiResponse);
                   // string _fruits = JsonConvert.SerializeObject(apiResponse);

         //       }
           // }
            return View(fruits);
        }
    }
}