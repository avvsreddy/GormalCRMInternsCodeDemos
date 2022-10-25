using System.ComponentModel.DataAnnotations;

namespace KnowledgeHubPortalMVCWebApplication.Models.Entities
{
    public class Article
    {
        public int ArticleID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Url]
        public string Url { get; set; }
        public string Description { get; set; }
        public int CatagoryID { get; set; }
        public Catagory Catagory { get; set; }
        public bool IsApproved { get; set; }
        public string SubmittedBy { get; set; }
        public DateTime DateSubmitted { get; set; }
    }
}
