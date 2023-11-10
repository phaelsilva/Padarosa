﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padarosa.Classes
{
    public class OrdemComanda
    {
        public int Id { get; set; }
        public int IdFicha { get; set; }
        public int IdProduto { get; set; }
        public int Quantidade { get; set;}
        public int IdResponsavel { get; set;}
        public DateTime DataAdicionado {  get; set; }
        public int Situacao { get; set;}
    }
}
