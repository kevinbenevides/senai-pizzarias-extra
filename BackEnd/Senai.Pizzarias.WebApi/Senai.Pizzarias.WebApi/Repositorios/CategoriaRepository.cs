using Senai.Pizzarias.WebApi.Domains;
using Senai.Pizzarias.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Pizzarias.WebApi.Repositorios
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public List<Categorias> Listar()
        {
            using(SenaiPizzariasContext ctx = new SenaiPizzariasContext())
            {
                return ctx.Categorias.ToList();
            }
        }
    }
}
