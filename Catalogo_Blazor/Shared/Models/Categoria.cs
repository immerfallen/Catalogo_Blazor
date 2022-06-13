﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo_Blazor.Shared.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        public string? Nome { get; set; }

        public string? Descricao { get; set; }

        public ICollection<Produto> Produtos { get; set; }
    }
}
