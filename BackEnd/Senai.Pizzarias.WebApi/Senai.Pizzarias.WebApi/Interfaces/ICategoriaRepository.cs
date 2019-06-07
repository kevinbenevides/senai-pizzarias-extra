using Senai.Pizzarias.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Pizzarias.WebApi.Interfaces
{
    interface ICategoriaRepository
    {
        List<Categorias> Listar();
    }
}
