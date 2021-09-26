using System;
using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
    public class Produto
    {
        [Display(Name = "Prod ID")]
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Range(1, 100, ErrorMessage = "Valor fora do range permitido, que é de 1 até 100")]
        public int Quantidade { get; set; }
        
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        
        public Categoria Categoria { get; set; }
    }
}
