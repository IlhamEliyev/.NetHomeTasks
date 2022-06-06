using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03._06._2022HomeTask.Models
{
    public class NewsDetail : BaseEntity
    {
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        public string LongText { get; set; }

        public int NewsId { get; set; }

        public News News { get; set; }
    }
}
