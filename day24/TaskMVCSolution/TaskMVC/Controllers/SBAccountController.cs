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
using TaskMVC.Models;

namespace TaskMVC.Controllers
{
    public class SBAccountController : Controller
    {
        // GET: SBAccountController
        public async Task<ActionResult> Index()
        {
            string BaseUrl = "http://localhost:40347/";
            var AccountInfo = new List<SBAccount>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/SBAccounts");
                if (Res.IsSuccessStatusCode)
                {
                    var BlogResponse = Res.Content.ReadAsStringAsync().Result;
                    AccountInfo = JsonConvert.DeserializeObject<List<SBAccount>>(BlogResponse);
                }
                return View(AccountInfo);
            }
        }

        // GET: SBAccountController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            SBAccount account = new SBAccount();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:40347/api/SBAccounts/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    account = JsonConvert.DeserializeObject<SBAccount>(apiResponse);
                }
            }
            return View(account);
        }

        // GET: SBAccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SBAccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(SBAccount Account)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(Account), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("http://localhost:40347/api/SBAccounts", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<SBAccount>(apiResponse);
                }
            }
            return RedirectToAction("Index");
        }

        // GET: SBAccountController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            TempData["AccountId"] = id;
            SBAccount Account = new SBAccount();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:40347/api/SBAccounts/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Account = JsonConvert.DeserializeObject<SBAccount>(apiResponse);
                }
            }
            return View(Account);
        }

        // POST: SBAccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(SBAccount Account)
        {
            int AccountId = Convert.ToInt32(TempData["AccountId"]);
            SBAccount a = new SBAccount();
            using (var httpclient = new HttpClient())
            {
                StringContent content1 = new StringContent(JsonConvert.SerializeObject(Account), Encoding.UTF8, "application/json");
                using (var response = await httpclient.PutAsync("http://localhost:40347/api/SBAccounts/" + AccountId, content1))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    a = JsonConvert.DeserializeObject<SBAccount>(apiResponse);
                }
            }
            return RedirectToAction("Index");
        }

        // GET: SBAccountController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            TempData["AccountId"] = id;
            SBAccount Account = new SBAccount();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:40347/api/SBAccounts/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Account = JsonConvert.DeserializeObject<SBAccount>(apiResponse);
                }
            }
            return View(Account);
        }

        // POST: SBAccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(SBAccount Account)
        {
            int AccountId = Convert.ToInt32(TempData["AccountId"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("http://localhost:40347/api/SBAccounts/" + AccountId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return RedirectToAction("Index");
        }
    }
}
