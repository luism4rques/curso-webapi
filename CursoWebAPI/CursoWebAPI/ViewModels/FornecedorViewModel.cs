using System;
using System.ComponentModel.DataAnnotations;

namespace CursoWebAPI.ViewModels
{
    public class FornecedorViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Documento { get; set; }

        public int TipoFornecedor { get; set; }

        public bool Ativo { get; set; }
    }
}