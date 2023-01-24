using Microsoft.AspNetCore.Mvc;

namespace Tarefas.Web.Controllers;

public class TarefasController : Controller
{
    public IActionResult Create ()
    {
        return View();
    }
};
