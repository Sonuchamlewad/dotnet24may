using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*namespace WebApplication1.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public List<Student> Get()
        {
            sampleDB1Context db = new sampleDB1Context();
            return db.Students.ToList();
        }
        [HttpPost]
        public string Post([FromBody] string sample)
        {
            sampleDB1Context db = new sampleDB1Context();
            Student s = new Student();
            s.Text = sample;
            db.Students.Add(s);
            db.SaveChanges();
            return "Success";
        }
    }
}
*/