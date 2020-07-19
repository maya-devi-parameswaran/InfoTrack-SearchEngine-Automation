using System.ComponentModel.DataAnnotations;

namespace SearchAutomation.Models
{
    public class HomeViewModel
    {
        [Required]
        public string SearchTerm { get; set; }

        [Required]
        public string Url { get; set; }
    }
}
