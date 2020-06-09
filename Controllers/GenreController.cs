using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LibaryAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LibaryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController: ControllerBase
      {
      private LibaryAPIContext _db;

      public GenreController(LibaryAPIContext db)
      {
        _db = db;
      }

        //testing get method
      [HttpGet]
      public ActionResult<IEnumerable<string>> Get(string genreName)
      {
          var query = _db.Genres.AsQueryable();
          if (genreName != null)
          {
              query = query.Where(entry => entry.GenreName == genreName);
          }
          return query.ToList();
      }

    





    }

}