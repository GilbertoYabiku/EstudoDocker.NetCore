using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EstudoDeploy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversorController : ControllerBase
    {
        [HttpGet("{libras}")]
        public object Get(double libras)
        {
            return new
            {
                Libras = libras,
                Kilos = libras * 0.453592
            };
        }
    }
}