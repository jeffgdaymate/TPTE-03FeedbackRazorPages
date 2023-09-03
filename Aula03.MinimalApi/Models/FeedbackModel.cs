using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Aula03.MinimalApi.Models
{
    public class FeedbackModel
    {
        public int IdFeedback { get; set; }

        [Required(ErrorMessage = "O nome do cliente é obrigatório.")]
        public string NomeCliente { get; set; }

        public string? EmailCliente { get; set; }

        [Required(ErrorMessage = "A data do feedback é obrigatória.")]
        public DateTime DataFeedback { get; set; }

        [Required(ErrorMessage = "O comentário é obrigatório.")]
        public string Comentario { get; set; }

        [Required(ErrorMessage = "A avaliação é obrigatória.")]
        [Range(1, 5, ErrorMessage = "A avaliação deve ser entre 1 e 5.")]
        public int Avaliacao { get; set; }

        // Construtor vazio
        public FeedbackModel()
        {
        }
    }
}