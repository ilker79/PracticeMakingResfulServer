using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PracticeMakingResfulServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {
        static Note ourNote = new Note();

        [HttpGet]

        public Note Get()
        {
            //Note returnnotes = ourNote;
            return ourNote;
        } 
    }
}
