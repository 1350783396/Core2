using Bll;
using Core2.Models;
using log4net;
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
        private ILog log = LogManager.GetLogger(Startup.repository.Name, typeof(HttpGlobalExceptionFilter));

        public ActionResult GetTest() 
        {
            CoreContext db = new CoreContext();
            var data = db.test1s.ToList();
            int a = 0;
            int b = 5 / a;

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
