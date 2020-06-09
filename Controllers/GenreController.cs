using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LibraryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController: ControllerBase
    {
        private LibraryAPIContext _db;

        public GenreController(LibraryAPIContext db)
        {
        _db = db;
        }

        //GET api/Genre or GET api/Genre/?genreName=Horror
        [HttpGet]
        public ActionResult<IEnumerable<Genre>> Get(string genreName)
        {
        var query = _db.Genres.AsQueryable();
        if (genreName != null)
        {
        query = query.Where(entry => entry.GenreName == genreName);
        }
        return query.ToList();
        }


        // GET api/Genre/5
        [HttpGet("{id}")]
        public ActionResult<Genre> Get(int id)
        {
        return _db.Genres.Include(entry => entry.Stories).ThenInclude(join => join.Story).Where(entry => entry.GenreId == id).FirstOrDefault();
        }

        // GET api/Genre/randomgenre
        [HttpGet("randomgenre")]
        public ActionResult<Genre> GetRandom()
        {
            Random rand = new Random();
            int toSkip = rand.Next(0, _db.Genres.Count());
            return _db.Genres.OrderBy(r => Guid.NewGuid()).Skip(toSkip).Take(1).First();
        }

        // POST api/Genre
        [HttpPost]

        public void Post([FromBody] Genre genre)
        {
            _db.Genres.Add(genre);
            _db.SaveChanges();
        }

        //Delete api/genre/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var genreToDelete = _db.Genres.FirstOrDefault(entry => entry.GenreId == id);
            _db.Genres.Remove(genreToDelete);
            _db.SaveChanges();
        }

        // PUT api/Genre/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Genre genre)
        {
            genre.GenreId = id;
            _db.Entry(genre).State = EntityState.Modified;
            _db.SaveChanges();
        }



    }

}