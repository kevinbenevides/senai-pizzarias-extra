using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Pizzarias.WebApi.Interfaces;
using Senai.Pizzarias.WebApi.Repositorios;

namespace Senai.Pizzarias.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private ICategoriaRepository CategoriaRepository { get; set; }
        public CategoriasController()
        {
            CategoriaRepository = new CategoriaRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                // contexto
                return Ok(CategoriaRepository.Listar());
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }
    }
}