using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Aula03.MinimalApi.Services;
using Aula03.MinimalApi.Models;

namespace Aula03.MinimalApi.Pages.Feeds
{
    public class Update : PageModel
    {
        private readonly FeedbackService _feedbackService;
        
        [BindProperty]
        public FeedbackModel FeedbackDetails { get; set; } = new();

        public Update(FeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        public IActionResult OnGet(int id)
        {
            var feedbackModel = _feedbackService.GetFeedbackById(id);
            if (feedbackModel == null)
            {
                return NotFound();
            }

            FeedbackDetails = feedbackModel;

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                _feedbackService.UpdateFeedback(FeedbackDetails);
                return RedirectToPage("Index");
            }
            catch (System.Exception)
            {
                return Page();
            }
        }
    }
}