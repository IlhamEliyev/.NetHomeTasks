using BizLand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizLand.ViewModels
{
    public class HomeViewModel
    {

        public List<Project> projects { get; set; }
        public List<ProjectCategory> projectCategories { get; set; }
    }
}
