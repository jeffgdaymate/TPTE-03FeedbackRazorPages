using System;
using Aula03.MinimalApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Aula03.MinimalApi.Services;


namespace Aula03.MinimalApi.Pages.Feeds
{
    public class Create : PageModel
    {
        private readonly FeedbackService _feedbackService;

        [BindProperty]
        public FeedbackModel FeedbackDetails { get; set; } = new();

        public Create(FeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                _feedbackService.AddFeedback(FeedbackDetails);
                return RedirectToPage("/Feeds/Index");
            }
            catch (Exception ex)
            {
                // Lançamento de exceção
                //Logger.LogError("Erro ao criar feedback.");
                return Page();
            }
        }
    }
}
