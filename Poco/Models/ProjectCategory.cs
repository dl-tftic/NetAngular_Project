using System;
using System.Collections.Generic;
using System.Text;

namespace DTO.Models
{
    public class ProjectCategory
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ProjectId { get; set; }
        public int? ParentProjectCategoryId { get; set; }
    }
}
