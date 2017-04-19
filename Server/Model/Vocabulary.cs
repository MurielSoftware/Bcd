using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    [Table("VOCABULARY")]
    public class Vocabulary : BaseEntity
    {
        public virtual string Word { get; set; }
        public virtual string Translate { get; set; }
    }
}
