using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiAngular.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : Controller
    {
        private Model.MyDBContext db;
        
        public ChatController(Model.MyDBContext context)
        {
            db = context;
        }
        [HttpGet("[action]")]
        public IActionResult Message()
        {
            List<Model.Message> lst = null;
            lst = db.Message.ToList();
            
            return Json(lst);
        }
    }
}
