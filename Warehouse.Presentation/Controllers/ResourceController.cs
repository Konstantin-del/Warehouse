using Microsoft.AspNetCore.Mvc;
using Warehouse.Application.Interfaces;
using Warehouse.Persistence.Entities;

namespace Warehouse.Presentation.Controllers;

[Route("api/resource")]
[ApiController]

public class ResourceController(IResourceService resource) : Controller
{
  
    [HttpGet]
    public ActionResult AddResource([FromQuery] string name)
    {
        Console.WriteLine("op");
        Console.WriteLine(name);
        var res = new Resource();
        res.Name = name;
        res.State = "active";
        
        resource.AddResource(res);
        return Ok();
    }
}
