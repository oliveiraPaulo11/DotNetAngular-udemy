using Microsoft.AspNetCore.Mvc;
using ProEventos.api.models;

namespace ProEventos.api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

    public IEnumerable<Evento> _evento =
        new Evento[]{
            new Evento() {
                EventoId = 2,
                Tema = "Angula e tudo mais",
                Local = "Joao Pessoa",
                Lote = "3° Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
                ImagemURL = "foto1.png"
            },
            new Evento() {
                EventoId = 1,
                Tema = "Angula e .NET",
                Local = "Recife",
                Lote = "1° Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
                ImagemURL = "foto.png"
            }
        };
    
    public EventoController(ILogger<EventoController> logger)
    {
    }

    [HttpGet]
    public  IEnumerable<Evento> Get()
    {
        return _evento;
        
    }
     [HttpGet("{id}")]
    public  IEnumerable<Evento> Getbyid(int id)
    {
        return _evento.Where(evento=> evento.EventoId == id);
        
    }
}
