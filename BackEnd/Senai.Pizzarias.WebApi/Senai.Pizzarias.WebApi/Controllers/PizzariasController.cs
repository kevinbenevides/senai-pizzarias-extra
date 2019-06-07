using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Pizzarias.WebApi.Domains;
using Senai.Pizzarias.WebApi.Interfaces;
using Senai.Pizzarias.WebApi.Repositorios;

namespace Senai.Pizzarias.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PizzariasController : ControllerBase
    {
        private IPizzariaRepository PizzariaRepository { get; set; }

        public PizzariasController()
        {
            PizzariaRepository = new PizzariaRepository();
        }

        [HttpPost]
        public IActionResult Cadastrar(Domains.Pizzarias pizzaria)
        {
            try
            {
                PizzariaRepository.Cadastrar(pizzaria);
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {

                // contexto
                return Ok(PizzariaRepository.Listar());
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }
    }
}