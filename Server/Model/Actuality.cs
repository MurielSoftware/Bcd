using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    [Table("ACTUALITY")]
    public class Actuality : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public DateTime? Date { get; set; }

        public Guid? UserDefinableId { get; set; }

        [ForeignKey("UserDefinableId")]
        public UserDefinable UserDefinable { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
