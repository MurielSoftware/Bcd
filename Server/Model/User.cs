using Shared.Core.Context;
using Shared.Dtos.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    [Table("USER")]
    public class User : UserDefinable, IOrderableEntity
    {
        public virtual BujinkanTitle BujinkanTitle { get; set; }

        [Required]
        public virtual string FirstName { get; set; }

        [Required]
        public virtual string Surname { get; set; }

        [Required]
        public virtual string Email { get; set; }

        [Required]
        public virtual string Password { get; set; }

        public virtual string Web { get; set; }
        public virtual string Facebook { get; set; }
        public virtual string Phone { get; set; }
        public virtual short? Dan { get; set; }
        public virtual int Order { get; set; }
        public virtual string Description { get; set; }

        public virtual Guid? CountryId { get; set; }
        public virtual Guid? DojoId { get; set; }
        public virtual Guid RoleId { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        [ForeignKey("DojoId")]
        public virtual Dojo Dojo { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        public virtual ICollection<BaseEvent> Events { get; set; }
        public virtual ICollection<Training> Trainings { get; set; }
    }
}
