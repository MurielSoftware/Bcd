using Shared.Core.Attributes;
using Shared.Core.Constants;
using Shared.Core.Dtos;
using Shared.Core.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Links
{
    public class LinkDto : BaseDto
    {
        [Display(Name = MessageKeyConstants.LABEL_NAME, ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string Name { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_LINK, ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        [Url(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_URL_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string Url { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_DESCRIPTION, ResourceType = typeof(Resource))]
        public virtual string Description { get; set; }

        public virtual Guid CategoryId { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_CATEGORY, ResourceType = typeof(Resource))]
        [ListReference(DaoConstants.ATTRIBUTE_CATEGORY)]
        public virtual ReferenceString CategoryReference { get; set; }
    }
}
