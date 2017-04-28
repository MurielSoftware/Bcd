using Shared.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Links
{
    public class LinkDto : BaseDto
    {
        public virtual string Name { get; set; }
        public virtual string Url { get; set; }
        public virtual string Description { get; set; }

        public virtual Guid CategoryId { get; set; }
    }
}
