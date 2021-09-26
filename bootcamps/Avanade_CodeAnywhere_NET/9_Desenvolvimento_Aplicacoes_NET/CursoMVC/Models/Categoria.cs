using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CursoMVC.Models
{
    public class Categoria
    {
        // properties
        public int Id { get; set; }// pk do banco

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "O campo Descrição é obrigatório")]
        public string Descricao { get; set; }

        //public List<Produto> Produtos { get; set; }
    }
}
