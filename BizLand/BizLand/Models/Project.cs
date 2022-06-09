using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizLand.Models
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string Image { get; set; }

        public int ProjectCategoryId { get; set; }
        public ProjectCategory ProjectCategory { get; set; }
    }
}
