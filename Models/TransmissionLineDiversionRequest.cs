using System.ComponentModel.DataAnnotations;

namespace form_using_blazor.Models
{
    public class TransmissionLineDiversionRequest
    {
        [Key]
        public int RequestId { get; set; }

        [Required(ErrorMessage = "Client Name is required")]
        public string ClientName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Project Details are required")]
        public string ProjectDetails { get; set; } = string.Empty;

        [Required(ErrorMessage = "Lines To Be Diverted is required")]
        public string LinesToBeDiverted { get; set; } = string.Empty;

        [Required(ErrorMessage = "Work Type is required")]
        public string WorkType { get; set; } = string.Empty;

        public DateTime DateOfRequest { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Timeline is required.")]
        public string? TimelineRequirement { get; set; }

        [Required(ErrorMessage = "Project Location is required.")]
        public string? ProjectLocation { get; set; }

        [Required(ErrorMessage = "Contact Person is required.")]
        public string? ContactPerson { get; set; }

        [RegularExpression(@"^[0-9]{10}$",
     ErrorMessage = "Enter a valid 10-digit mobile number.")]
        public string? ContactNumber { get; set; }

        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        public string? Email { get; set; }

        public int? PDFEntry { get; set; }

        public string? RequestStatus { get; set; }

        public string? Remarks { get; set; }
    }
}