﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    [Table("EVENT")]
    public class Event : UserDefinable
    {
        public virtual string Theme { get; set; }
        public virtual DateTime Start { get; set; }
        public virtual DateTime End { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string Zipcode { get; set; }
        public virtual string Gps { get; set; }
        public virtual string Facebook { get; set; }
        public virtual string Description { get; set; }
        public virtual bool ShowPrize { get; set; }
        public virtual short? PrizeMember { get; set; }
        public virtual short? PrizeNomember { get; set; }
     //   public virtual Currency Currency { get; set; }
        public virtual bool EnableRegistration { get; set; }
        public virtual DateTime? RegistrationDeadline { get; set; }
        public virtual int CurrentParticipiants { get; set; }
        public virtual int? MaximumParticipiants { get; set; }
        public virtual short? Prepayment { get; set; }
        public virtual DateTime? PrepaymentDeadline { get; set; }
        public virtual string AccountNumber { get; set; }
        public virtual string Discriminator { get; set; }

        public virtual Guid? CountryId { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public override string ToString()
        {
            return Theme;
        }
    }
}
