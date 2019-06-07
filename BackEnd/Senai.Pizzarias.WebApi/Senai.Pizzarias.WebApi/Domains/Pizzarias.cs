using System;
using System.Collections.Generic;

namespace Senai.Pizzarias.WebApi.Domains
{
    public partial class Pizzarias
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public bool OpcaoVegana { get; set; }
        public int? IdCategoria { get; set; }

        public Categorias IdCategoriaNavigation { get; set; }
    }
}
