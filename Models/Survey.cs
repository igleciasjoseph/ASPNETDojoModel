using System.ComponentModel.DataAnnotations;
namespace DojoModel.Models
{
    public class Survey {
        [Required(ErrorMessage="Field must not be empty")]
        [MinLength(2, ErrorMessage ="Field must be at least 2 characters long")]
        public string name {get;set;}
        [Required(ErrorMessage = "Field must not be empty")]
        public string location {get;set;}
        [Required(ErrorMessage = "Field must not be empty")]
        public string language {get;set;}
        [MinLength(20, ErrorMessage = "Field must be at least 20 characters long")]
        public string comment {get;set;}
    }
}