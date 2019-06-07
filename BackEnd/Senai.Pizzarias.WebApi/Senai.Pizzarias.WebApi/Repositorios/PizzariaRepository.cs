using Microsoft.EntityFrameworkCore;
using Senai.Pizzarias.WebApi.Domains;
using Senai.Pizzarias.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Pizzarias.WebApi.Repositorios
{
    public class PizzariaRepository : IPizzariaRepository
    {
        public void Cadastrar(Domains.Pizzarias pizzaria)
        {
            using (SenaiPizzariasContext ctx = new SenaiPizzariasContext())
            {
                ctx.Pizzarias.Add(pizzaria);
                ctx.SaveChanges(); 
            }

        }

        public List<Domains.Pizzarias> Listar()
        {
            using(SenaiPizzariasContext ctx = new SenaiPizzariasContext())
            {
                return ctx.Pizzarias.Include(x => x.IdCategoriaNavigation).ToList();
            }

        }
    }
}
