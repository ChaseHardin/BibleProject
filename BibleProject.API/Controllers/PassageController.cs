using System.Collections.Generic;
using BibleProject.Business;
using BibleProject.Business.Services;
using Microsoft.AspNetCore.Mvc;

namespace BibleProject.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PassageController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<PassageViewModel> GetPassages()
        {
            return new PassageService().GetPassages();
        }
    }
}