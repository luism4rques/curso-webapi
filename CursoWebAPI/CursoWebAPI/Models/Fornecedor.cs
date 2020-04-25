using System.Collections.Generic;

namespace CursoWebAPI.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }

        public string Documento { get; set; }

        public int TipoFornecedor { get; set; }

        public bool Ativo { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
