using System.Collections.Generic;
using Aula03.MinimalApi.Models;

namespace Aula03.MinimalApi.Services
{
    public class FeedbackService
    {
        private static List<FeedbackModel> Feedbacks = new List<FeedbackModel>
        {
            new FeedbackModel
            {
                IdFeedback = 1,
                NomeCliente = "Cliente 1",
                EmailCliente = "cliente1@email.com",
                DataFeedback = System.DateTime.Now.AddDays(-1),
                Comentario = "Muito bom!",
                Avaliacao = 5
            },
            new FeedbackModel
            {
                IdFeedback = 2,
                NomeCliente = "Cliente 2",
                EmailCliente = "cliente2@email.com",
                DataFeedback = System.DateTime.Now,
                Comentario = "Poderia melhorar.",
                Avaliacao = 3
            }
        };

        public List<FeedbackModel> GetAllFeedbacks()
        {
            return Feedbacks;
        }

        public void AddFeedback(FeedbackModel newFeedback)
        {
            // Gerar um novo IdFeedback com base no último feedback da lista.
            newFeedback.IdFeedback = Feedbacks.Count > 0 ? Feedbacks[^1].IdFeedback + 1 : 1;
            Feedbacks.Add(newFeedback);
        }

        public void UpdateFeedback(FeedbackModel feedbackToUpdate)
        {
            var existingFeedback = Feedbacks.FirstOrDefault(f => f.IdFeedback == feedbackToUpdate.IdFeedback);
            if (existingFeedback != null)
            {
                existingFeedback.NomeCliente = feedbackToUpdate.NomeCliente;
                existingFeedback.EmailCliente = feedbackToUpdate.EmailCliente;
                existingFeedback.DataFeedback = feedbackToUpdate.DataFeedback;
                existingFeedback.Comentario = feedbackToUpdate.Comentario;
                existingFeedback.Avaliacao = feedbackToUpdate.Avaliacao;
            }
            // Lançar uma exceção se o feedback não for encontrado.
            
        }

        public FeedbackModel GetFeedbackById(int id)
        {
            return Feedbacks.FirstOrDefault(f => f.IdFeedback == id);
        }

        public void DeleteFeedback(int id)
        {
            var feedbackToRemove = Feedbacks.FirstOrDefault(f => f.IdFeedback == id);
            if (feedbackToRemove != null)
            {
                Feedbacks.Remove(feedbackToRemove);
            }
            // Lançar uma exceção se o feedback não for encontrado.
            
        }

    }
}
