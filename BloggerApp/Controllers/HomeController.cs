using BloggerApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Blog.Service;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace BloggerApp.Controllers
{
    public class HomeController(ILogger<HomeController> logger, HttpClient httpClient) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;
        private readonly HttpClient _httpClient = httpClient;



        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetAsync($"https://localhost:7026/api/Post/GetAllPosts");
            var content = await response.Content.ReadAsStringAsync();
            var content2 = await response.Content.ReadAsByteArrayAsync();

            var posts = JsonConvert.DeserializeObject<List<PostModel>>(content);

            HttpContext.Session.Set("Articles", content2);

            return View(posts);
        }

        public IActionResult ArticleDetails(string url)
        {
            // Retrieve the list from session
            var articles = HttpContext.Session.Get<List<PostModel>>("Articles");
            // Find the specific article
            var article = articles?.FirstOrDefault(a => a.Title == url);

            return View(article);
        }

    }
}
