﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizLand.Models
{
    public class ProjectCategory : BaseEntity
    {
        public string Name { get; set; }

        public List<Project> Projects { get; set; }
    }
}
