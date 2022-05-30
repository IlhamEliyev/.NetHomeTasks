using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeTask.Models
{
    public class MainContext : BaseEntity
    {
        public string MainText { get; set; }
        public string Text { get; set; }
    }
}
