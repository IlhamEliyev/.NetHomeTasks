using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask.Models
{
    public class Project : BaseEntity
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
}
