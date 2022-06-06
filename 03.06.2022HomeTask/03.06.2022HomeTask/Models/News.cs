using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03._06._2022HomeTask.Models
{
    public class News : BaseEntity
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Text { get; set; }

        public List<NewsDetail> NewsDetails { get; set; }
    }
}
