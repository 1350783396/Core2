using Bll;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core2.Controllers
{
    //[ApiController]
    //[Route("[controller]/[action]")]
    public class Test1Controller:Controller
    {
        
        public ActionResult GetTest() 
        {
            CoreContext db = new CoreContext();
            var data = db.test1s.ToList();
            return Ok(data);
        }

        public ActionResult GetTest2()
        {
            CoreContext db = new CoreContext();
            var data = db.test1s.ToList();
            return Ok(data);
        }

    }
}
