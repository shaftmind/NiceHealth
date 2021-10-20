using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiceHealth.Controllers
{
    public class PostoController
    {

        public readonly IPostoService _postoService;


        [HttpGet]
        public Task<IActionResult> Get()
        {
            _postoService.
        }
    }
}
