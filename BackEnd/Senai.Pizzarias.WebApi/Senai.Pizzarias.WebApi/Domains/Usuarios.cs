﻿using System;
using System.Collections.Generic;

namespace Senai.Pizzarias.WebApi.Domains
{
    public partial class Usuarios
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
