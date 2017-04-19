﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    [Table("MENU_ITEM")]
    public class MenuItem : BaseEntity//, IOrderableEntity
    {
        public virtual string Name { get; set; }
        public virtual string Url { get; set; }
        public virtual bool BuiltIn { get; set; }
        public virtual int Order { get; set; }
   //     public virtual MenuEntityType EntityType { get; set; }
     //   public virtual AssociationType AssociationType { get; set; }
        public virtual Guid? BlogCategoryId { get; set; }
        public virtual int Level { get; set; }

        public virtual Guid? ParentMenuItemId { get; set; }
        public virtual Guid? UserDefinableId { get; set; }
    
        [ForeignKey("ParentMenuItemId")]
        public virtual MenuItem ParentMenuItem { get; set; }

        [ForeignKey("UserDefinableId")]
        public virtual UserDefinable UserDefinable { get; set; }

        public virtual ICollection<MenuItem> SubMenuItems { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}