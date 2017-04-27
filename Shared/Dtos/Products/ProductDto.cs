using Shared.Core.Attributes;
using Shared.Core.Constants;
using Shared.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Products
{
    public class ProductDto : BaseDto
    {
        public virtual string Name { get; set; }
        public virtual string Url { get; set; }
        public virtual string Description { get; set; }
        public virtual int? Prize { get; set; }
        public virtual bool ShowPrize { get; set; }
        public virtual Currency Currency { get; set; }

        public virtual Guid CategoryId { get; set; }

        [Reference(DaoConstants.ATTRIBUTE_CATEGORY)]
        public virtual ReferenceString CategoryReference { get; set; }
    }
}
