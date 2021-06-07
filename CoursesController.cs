using Microsoft.AspNetCore.Mvc;
using System;

public class CoursesController : Controller 
{
    public IActionResult index()
    {
        return Content("Ciao sono index");
    }
    public IActionResult detail(string id) 
    {
        return Content($"Ciao sono detail, ho ricevuto l id {id}" );
    }
}
