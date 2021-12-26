using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class HomeController : Controller
  {
    private readonly HairSalonContext _db;
    public HomeController(HairSalonContext db)
    {
      _db = db;
    }
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Client> model = _db.Clients.ToList(); //This is all just so I only show the link to view all clients if there are in fact clients.
      return View(model);
    }
  }
}