using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo_Blazor.Shared.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [MaxLength(100)]
        public string? Nome { get; set; }

        [MaxLength(200)]
        public string? Descricao { get; set; }

        public decimal Preco { get; set; }

        [MaxLength(250)]
        public string? ImagemUrl { get; set; }

        public int CategoriId { get; set; }

        public virtual Categoria? Categoria { get; set; }
    }
}
