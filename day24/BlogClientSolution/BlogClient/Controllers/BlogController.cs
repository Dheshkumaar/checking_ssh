using BlogClient.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BlogClient.Controllers
{
    public class BlogController : Controller
    {
        // GET: BlogController
        public async Task<ActionResult> Index()
        {
            string BaseUrl = "http://localhost:49872/";
            var BlogInfo = new List<Blog>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/Blogs");
                if (Res.IsSuccessStatusCode)
                {
                    var BlogResponse = Res.Content.ReadAsStringAsync().Result;
                    BlogInfo = JsonConvert.DeserializeObject<List<Blog>>(BlogResponse);
                }
                return View(BlogInfo);
            }
        }

        // GET: BlogController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            Blog blog = new Blog();
            using( var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:49872/api/Blogs/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    blog = JsonConvert.DeserializeObject<Blog>(apiResponse);
                }
            }
            return View(blog);
        }

        // GET: BlogController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Blog blog)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(blog), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("http://localhost:49872/api/Blogs",content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<Blog>(apiResponse);
                }
            }
            return RedirectToAction("Index");
        }

        // GET: BlogController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            TempData["blogId"] = id;
            Blog blog = new Blog();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:49872/api/Blogs/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    blog = JsonConvert.DeserializeObject<Blog>(apiResponse);
                }
            }
            return View(blog);
        }

        // POST: BlogController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Blog blog)
        {
            int blogId = Convert.ToInt32(TempData["blogId"]);
            Blog b = new Blog();
            using (var httpclient = new HttpClient())
            {
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(blog), Encoding.UTF8, "application/json");
                using (var response = await httpclient.PutAsync("http://localhost:49872/api/Blogs/" + blogId, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    b = JsonConvert.DeserializeObject<Blog>(apiResponse);
                }
            }
            return RedirectToAction("Index");
        }

        // GET: BlogController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            TempData["blogId"] = id;
            Blog blog = new Blog();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:49872/api/Blogs/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    blog = JsonConvert.DeserializeObject<Blog>(apiResponse);
                }
            }
            return View(blog);
        }

        // POST: BlogController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Blog blog)
        {
            int blogId = Convert.ToInt32(TempData["blogId"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("http://localhost:49872/api/Blogs/" + blogId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return RedirectToAction("Index");
        }
    }
}
