using Microsoft.AspNetCore.Mvc;
using Tarefas.Web.Models;

namespace Tarefas.Web.Controllers;

public class TarefasController : Controller
{
    public List<TarefaViewModel> listaDeTarefas{get;set;}
    public TarefasController ()
    {        
        listaDeTarefas = new List<TarefaViewModel>()
        {
            new TarefaViewModel (){ Id = 1, Titulo = "Escovar os dentes", Descricao = "Usar o banheiro"},
            new TarefaViewModel (){ Id = 2, Titulo = "Tomar cafe", Descricao = "Cafe com pao"},
            new TarefaViewModel (){ Id = 3, Titulo = "Lavar a roupa", Descricao = "Pegar no cesto e por na maquina"}
        };
        
    }
    
    public IActionResult Create ()
    {
        return View();
    }

    public IActionResult Index()
    {
        return View(listaDeTarefas);
    }

    public IActionResult Details (int id)
    {
       // var tarefa = listaDeTarefas.Find(tarefa=>Id=id),
        var tarefa = listaDeTarefas.Find(tarefa=>tarefa.Id==id);
        return View(tarefa);
    }
    
};
