using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Pizzarias.WebApi.Interfaces
{
    interface IPizzariaRepository
    {
        void Cadastrar(Domains.Pizzarias pizzaria);

        List<Domains.Pizzarias> Listar();
    }
}
