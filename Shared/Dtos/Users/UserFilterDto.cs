using Shared.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Users
{
    public class UserFilterDto : BaseFilterDto
    {
        public virtual string FirstName { get; set; }
        public virtual string Surname { get; set; }
    }
}
