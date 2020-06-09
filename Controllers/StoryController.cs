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
    public class StoryController : ControllerBase
    {
        private LibraryAPIContext _db;

        public StoryController(LibraryAPIContext db)
        {
            _db = db;
        }

        // GET api/Story or Get api/Story/?storyName=octobers gold 
        [HttpGet]
        public ActionResult<IEnumerable<Story>> Get(string storyName, string storyDetails)
        {
            var query = _db.Stories.AsQueryable();

            if(storyName != null)
            {
                query = query.Where(entry => entry.StoryName == storyName);
            }
            return query.ToList();
        }

        // GET api/Story/5
        [HttpGet("{id}")]
        public ActionResult<Story> Get(int id)
        {
            return _db.Stories.Include(entry => entry.Genres).ThenInclude(join => join.Genre).Where(entry => entry.StoryId == id).FirstOrDefault();
        }



        [HttpPost]
        public void Post([FromBody] Story story)
        {
          _db.Stories.Add(story);
          _db.SaveChanges();
        }

        // DELETE api/Story/3
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var  storyToDelete = _db.Stories.FirstOrDefault(entry => entry.StoryId == id);
            _db.Stories.Remove(storyToDelete);
            _db.SaveChanges();
        }

        // PUT api/Story/3
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Story story)
        {
            story.StoryId = id;
            _db.Entry(story).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}