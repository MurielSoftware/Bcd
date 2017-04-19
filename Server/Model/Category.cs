﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    [Table("CATEGORY")]
    public class Category : BaseEntity
    {
        public virtual string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
