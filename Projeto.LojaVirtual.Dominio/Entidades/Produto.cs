﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.LojaVirtual.Dominio.Entidades
{
    public  class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal preco { get; set; }
        public string Categoria { get; set; }



    }
}
