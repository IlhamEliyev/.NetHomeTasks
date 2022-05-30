using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask.Models
{
    public class News :BaseEntity
    {
        public string NowDate { get; set; }
        public string MainText { get; set; }
        public String Text { get; set; }

    }
}
