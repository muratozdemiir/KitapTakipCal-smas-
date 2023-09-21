using Microsoft.AspNetCore.Mvc;
using KitapTakip.Models;
using KitapTakip.Utility;

namespace KitapTakip.Controllers;

public class KitapTuruController : Controller
{

    private readonly UygulamaDbContext _uygulamaDbContext;
    public KitapTuruController(UygulamaDbContext context)
    {
        _uygulamaDbContext = context;
    }
    public IActionResult Index()
    {
        List<KitapTuru> objKitapTuruList= _uygulamaDbContext.KitapTurleri.ToList();
        return View(objKitapTuruList);
    }

    public IActionResult Ekle()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Ekle(KitapTuru kitapturu)
    {
        if (ModelState.IsValid)
        {
            _uygulamaDbContext.KitapTurleri.Add(kitapturu);
            _uygulamaDbContext.SaveChanges();   //savechanges yaparak bilgilerin veri tabanına eklenmesini sağladım.

            return RedirectToAction("Index", "KitapTuru"); //chatgpt den aldım.
        }
        return View();
    }


    [HttpGet]
    public IActionResult Delete(int id)
    {
        var bookTuru = _uygulamaDbContext.KitapTurleri.Find(id);
        _uygulamaDbContext.KitapTurleri.Remove(bookTuru);
        _uygulamaDbContext.SaveChanges();
        return RedirectToAction("Index");
    }

}
