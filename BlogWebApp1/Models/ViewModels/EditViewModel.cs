using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogWebApp1.Models.ViewModels
{
    public class EditViewModel
    {
        public Post Post { get; internal set; }
        [ValidateNever]
        public List<SelectListItem> Categories { get; internal set; }
        public IFormFile? FeatureImage { get; set; }
    }
}
