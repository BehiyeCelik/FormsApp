using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FormsApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormsApp.Controllers;

public class HomeController : Controller
{
    public HomeController()
    {
    }

    public IActionResult Index(string searchString, string category ) // parametremizi belirledik
    {
        var products = Repository.Products;     //Products bilgisini aldık 

        if(!String.IsNullOrEmpty(searchString))   // parametre null değilse çalışması gerekiyor
        {
            ViewBag.SearchString = searchString; // bunun sayesinde aradığımız kelime arama yerinde yazılı olarak kalacak kaybolmayacak.Get Formu dersi için geçerli. 
            products = products.Where(p => p.Name.ToLower().Contains(searchString)).ToList(); // her bir product bilgisini alacağız ve searchstring içinde varsa bir listeye aktarılsın ve bize geri dönsün ismin içinde küçük harf kullanırsın diye de Tolower koydum.
        }
        if(!String.IsNullOrEmpty(category) && category != "0")
        {
            products = products.Where(p => p.CategoryId == int.Parse(category)).ToList(); //Gelen her bir produckt kontrol edilir CatgoryId si yukarıdaki gönderilenle aynıysa, string olarak alıyoruz ama int yapmamız lazım çünkü sayı. bunu da product ın içine at. 
        }

        // ViewBag.Categories = new SelectList(Repository.Categories, "CategoryId", "Name", category); //görünürde name var olacak ama arka tarafta categoryıd nin değeri dönecek. 
        var model = new ProductViewModel{
                Products=products,
                Categories= Repository.Categories,
                SelectedCategory= category
        }; 
                return View(model);
    }
    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Categories = Repository.Categories;
        return View();
    }
    [HttpPost]
    public IActionResult Create(Product model)
    {
        return View();
    }
}