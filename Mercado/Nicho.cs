﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    public class Nicho
    {
        public int Id { get; set; }
        public string NomeObjeto { get; set; }
        public Cliente Cliente { get; set; }
    }
}
