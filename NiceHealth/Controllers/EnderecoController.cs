using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NiceHealth.Controllers
{
    public class EnderecoController
    {

        public readonly IEnderecoService _enderecoService;



        [HttpGet]
        public Task<IActionResult> Get()
        {

        }

    }
}
