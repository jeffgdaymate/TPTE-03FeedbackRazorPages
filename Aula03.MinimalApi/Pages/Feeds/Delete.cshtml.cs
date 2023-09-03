using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Aula03.MinimalApi.Models;
using Aula03.MinimalApi.Services;

namespace Aula03.MinimalApi.Pages.Feeds
{
    public class Delete : PageModel
    {
        private readonly FeedbackService _feedbackService;
        [BindProperty]
        public FeedbackModel FeedbackDetails { get; set; } = new();

        public Delete(FeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        public IActionResult OnPost(int id)
        {
            _feedbackService.DeleteFeedback(id);
            return RedirectToPage("Index");
        }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var feedback = _feedbackService.GetFeedbackById(id.Value);

            if (feedback == null)
            {
                return NotFound();
            }

            FeedbackDetails = feedback;

            return Page();
        }
    }
}