using System.Reflection.PortableExecutable;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

using crud;
using dal;
namespace NewMvc.Controllers;

public class CrudcontactController : Controller
{
    private readonly ILogger<CrudcontactController> _logger;

    public CrudcontactController(ILogger<CrudcontactController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Crudcontact> list=DbManager.getallcontacts();
        ViewBag.insert=list;
        return View();
    }
    

    public IActionResult Registarion(){
        return View();
    }
    [HttpPost]
    public IActionResult  insert(Crudcontact cont){
       
       if(!ModelState.IsValid){

               
          return View();

        }
        DbManager.insertcontact(cont);
        return RedirectToAction("Index");
    }
    public IActionResult update(int eid)
    {
        Crudcontact e=DbManager.findcontact(eid);
        
        Console.WriteLine("eeeeeee"+eid);
        ViewBag.update=e;
      
        return View();
    }
    public IActionResult updatee(Crudcontact e)
    {
        Console.WriteLine("eeeeeee"+e.id);
        DbManager.updatecontact(e);
        return RedirectToAction("Index");
    }
    public IActionResult delete(int ssn)
    {
        Console.WriteLine("dfghj"+ssn);
        DbManager.delcontact(ssn);
        return RedirectToAction("Index");
    }
    
      public IActionResult find(int eidd)
    {
        Console.WriteLine("dfghj"+eidd);
       Crudcontact e= DbManager.findcontact(eidd);
       
        ViewBag.find=e;
        return View();
    }
 
}
