using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    [Table("PRODUCT")]
    public class Product : UserDefinable
    {
        public virtual string Name { get; set; }
        public virtual string Url { get; set; }
        public virtual string Description { get; set; }
        public virtual int? Prize { get; set; }
        public virtual bool ShowPrize { get; set; }
        public virtual Currency Currency { get; set; }

        public virtual Guid CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ProductCategory Category { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
