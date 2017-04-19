﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    [Table("LINK")]
    public class Link : BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual string Url { get; set; }
      //  public virtual LinkType LinkType { get; set; }

        public virtual string Description { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}