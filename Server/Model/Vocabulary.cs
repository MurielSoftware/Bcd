using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    [Table("VOCABULARY")]
    public class Vocabulary : BaseEntity
    {
        [Required]
        public virtual string Word { get; set; }

        [Required]
        public virtual string Translate { get; set; }
    }
}
