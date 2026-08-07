using System.Diagnostics;
using Microsoft.AspNetCore.Mvc; // MVC Araçlarını kullanabilmek için 
using OkulYonetim.Models;


namespace OkulYonetim.Controllers;

public class DenemeController : Controller
{
    // "Controller sınıfından türetiyoruz."
    // Bu sayede View(), redirectoAction() Gini hazır metotlar geliyor.
public IActionResult Merhaba()
    {
        // Viewbag : Controller'dan View'a kiçik veri taşımanın en kolay yolu
        ViewBag.Mesaj = "Merhaba Bu benim İlk Sayfam";
        ViewBag.Tarih = DateTime.Now;
        ViewBag.Sayi = 100;
        return View(); //Views/deneme/Merhaba.cshtml dosyasını arar.
    }

}

