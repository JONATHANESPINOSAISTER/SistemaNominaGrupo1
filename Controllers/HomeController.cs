using Microsoft.AspNetCore.Mvc;
namespace SistemaNominaGrupo1.Controllers;
public class HomeController : Controller
{
    public IActionResult Index() => View();
}
