using System;

namespace CursoWebAPI.Models
{
    public class Produto : Entity
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public Guid FornecedorId { get; set; }

        public Fornecedor Fornecedor { get; set; }
    }
}
