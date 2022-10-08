﻿using System.ComponentModel.DataAnnotations;

namespace KnowledgeHubPortalMVCWebApplication.Models.Entities
{
    public class Catagory
    {
        public int CatagoryID { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
    }
}