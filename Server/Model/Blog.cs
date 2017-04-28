using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    [Table("BLOG")]
    public class Blog : UserDefinable
    {
        [Required]
        public virtual string Name { get; set; }

        [Required]
        public virtual string Description { get; set; }

        public virtual bool BuiltIn { get; set; }

        public virtual Guid? UserId { get; set; }
        public virtual Guid CategoryId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("CategoryId")]
        public virtual BlogCategory Category { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }
}
