using System.ComponentModel.DataAnnotations;

namespace form_using_blazor.Models
{
    public class Documents
    {
        [Key]
        public int DocId { get; set; }

        public Guid GUID { get; set; }

        public string? DocName { get; set; }

        public string? DocType { get; set; }

        public string? Extension { get; set; }

        public string? ContentType { get; set; }

        public long FileSize { get; set; }

        public string? Status { get; set; }

        public string? UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string? UpdatedFrom { get; set; }

        public string? InsertedBy { get; set; }

        public DateTime? InsertedOn { get; set; }

        public string? InsertedFrom { get; set; }
        public string? FilePath { get; set; }
    }
}
