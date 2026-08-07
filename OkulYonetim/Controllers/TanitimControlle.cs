using System.Diagnostics;
using Microsoft.AspNetCore.Mvc; // MVC Araçlarını kullanabilmek için 
using OkulYonetim.Models;


namespace OkulYonetim.Controllers;

public class TanitimController : Controller
{
    // "Controller sınıfından türetiyoruz."
    // Bu sayede View(), redirectoAction() Gini hazır metotlar geliyor.
public IActionResult BeniTani()
    {
        // Viewbag : Controller'dan View'a kiçik veri taşımanın en kolay yolu
        ViewBag.Mesaj = "Özcan Emre Gönültaş";
        ViewBag.Mesaj2 = "Benim Hakkımda Kısa Bilgi";
        ViewBag.Mesaj3 = "Bilgisayar Mühendisliği Öğrencisiyim";
        return View(); //Views/tanitim/Ben.cshtml dosyasını arar.
    }

}