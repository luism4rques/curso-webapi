using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoWebAPI.Model
{
    public class Fornecedor
    {
        public Guid FornecedorId { get; set; }

        public string Nome { get; set; }

        public string Documento { get; set; }

        public int TipoFornecedor { get; set; }

        public bool Ativo { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
