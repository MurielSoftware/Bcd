using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    [Table("QUESTION")]
    public class Question : BaseEntity
    {
        [Required]
        public virtual string QuestionMark { get; set; }

        [Required]
        public virtual string Answer { get; set; }
    }
}
