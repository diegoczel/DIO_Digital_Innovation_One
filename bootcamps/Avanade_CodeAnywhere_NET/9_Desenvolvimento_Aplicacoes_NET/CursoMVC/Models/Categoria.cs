using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
    public class Categoria
    {
        // properties
        public int Id { get; set; }// pk do banco

        [Display(Name = "Descri��o")]
        [Required(ErrorMessage = "O campo Descri��o � obrigat�rio")]
        public string Descricao { get; set; }

        //public List<Produto> Produtos { get; set; }
    }
}
