using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC_Carrefour.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage ="A Descrição é Obrigatória.")]
        public string Descricao { get; set; }

        //public List<Produto> Produtos { get; set; }
    }
}
