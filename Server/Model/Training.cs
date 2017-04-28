using Shared.Dtos.Trainings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    [Table("TRAINING")]
    public class Training : UserDefinable
    {
        public virtual Day Day { get; set; }
        public virtual DateTime Start { get; set; }
        public virtual DateTime End { get; set; }
        public virtual bool ForChildren { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string Zipcode { get; set; }
        public virtual string Gps { get; set; }
        public virtual string Description { get; set; }

        public virtual Guid UserId { get; set; }
        public virtual Guid? CountryId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
    }
}
