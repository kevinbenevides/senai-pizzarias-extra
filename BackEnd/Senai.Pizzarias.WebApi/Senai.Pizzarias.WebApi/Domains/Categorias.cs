﻿using System;
using System.Collections.Generic;

namespace Senai.Pizzarias.WebApi.Domains
{
    public partial class Categorias
    {
        public Categorias()
        {
            Pizzarias = new HashSet<Pizzarias>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }

        public ICollection<Pizzarias> Pizzarias { get; set; }
    }
}
