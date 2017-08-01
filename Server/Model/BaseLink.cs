using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    [Table("LINK")]
    public abstract class BaseLink : BaseEntity
    {
        [Required]
        public virtual string Name { get; set; }

        public virtual string Url { get; set; }
        public virtual string Description { get; set; }

        public virtual Guid CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual LinkCategory Category { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
