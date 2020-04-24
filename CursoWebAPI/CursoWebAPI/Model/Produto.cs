using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoWebAPI.Model
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public Guid FornecedorId { get; set; }

        public Fornecedor Fornecedor { get; set; }
    }
}
