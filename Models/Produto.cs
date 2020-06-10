using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC_Carrefour.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "A Descrição é Obrigatória.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A Quantidade é Obrigatória.")]
        [Range(1, 10, ErrorMessage ="Valor fora do Quantidade Minima de 1 e Quantidade Máximo de 10 itens.")]
        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
