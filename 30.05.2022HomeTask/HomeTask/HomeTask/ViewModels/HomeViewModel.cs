using HomeTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask.ViewModels
{
    public class HomeViewModel
    {
        public List<Banner> banners { get; set; }
        public List<MainContext> mainContexts { get; set; }

        public List<Cities> cities { get; set; }

        public List<TestMonials> testMonials{ get; set; }

        public List<News> news { get; set; }
        public List<Project> projects { get; set; }


    }
}
