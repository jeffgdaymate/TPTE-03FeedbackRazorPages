using System.Collections.Generic;
using Aula03.MinimalApi.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Aula03.MinimalApi.Services;

namespace Aula03.MinimalApi.Pages.Feeds
{
    public class Index : PageModel
    {
        private readonly FeedbackService _feedbackService;

        public Index(FeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        public List<FeedbackModel> FeedbackList { get; set; }

        public void OnGet()
        {
            FeedbackList = _feedbackService.GetAllFeedbacks();
        }
    }
}
