using Microsoft.AspNetCore.Mvc;
using System;

public class HomeController : Controller
{
   public  IActionResult Index() 
    {
        return Content("Ciao sono controller :D");
    }

}
