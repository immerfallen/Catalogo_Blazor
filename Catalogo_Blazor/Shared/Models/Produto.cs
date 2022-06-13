using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo_Blazor.Shared.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public string ImagemUrl { get; set; }

        public int CategoriId { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}
