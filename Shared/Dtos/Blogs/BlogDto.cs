using Shared.Core.Attributes;
using Shared.Core.Constants;
using Shared.Core.Dtos;
using System;
using System.ComponentModel.DataAnnotations;
using Shared.I18n.Resources;
using Shared.I18n.Constants;

namespace Shared.Dtos.Blogs
{
    public class BlogDto : UserDefinableDto
    {
        [Display(Name = MessageKeyConstants.LABEL_NAME, ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string Name { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_DESCRIPTION, ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string Description { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_BUILTIN, ResourceType = typeof(Resource))]
        public virtual bool BuiltIn { get; set; }

        public virtual Guid? UserId { get; set; }
        public virtual Guid CategoryId { get; set; }

        [Reference(DaoConstants.ATTRIBUTE_USER)]
        public virtual ReferenceString UserReference { get; set; }

        [ListReference(DaoConstants.ATTRIBUTE_CATEGORY)]
        public virtual ReferenceString CategoryReference { get; set; }
    }
}
