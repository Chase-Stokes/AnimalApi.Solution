using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalApi.Models;

namespace AnimalApi.Controllers
{
  [Route("api/animals")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly AnimalApiContext _db;
    public AnimalsController(AnimalApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get(string species, string sex, string name, int age, string breed )
    {
      var query = _db.Animals.AsQueryable();

      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }

      if (sex != null)
      {
        query = query.Where(entry => entry.Sex == sex);
      }    

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }      
      
      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }      
      
      if (age > 0)
      {
        query = query.Where(entry => entry.Age >= age);
      }      

      return await query.ToListAsync();
    }
  }
}