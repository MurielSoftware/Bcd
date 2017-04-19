using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    [Table("DOJO")]
    public class Dojo : UserDefinable
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual bool BuiltIn { get; set; }
      //  public virtual OrganizationType OrganizationType { get; set; }
        public virtual string CivicAssociationRegistration { get; set; }
        public virtual string Ic { get; set; }
        public virtual string Email { get; set; }
        public virtual string Facebook { get; set; }
        public virtual string HeaderPhoto { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
