using Shared.Core.Constants;
using Shared.Core.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Dojos
{
    public class DojoDto : UserDefinableDto
    {
        [Display(Name = MessageKeyConstants.LABEL_NAME, ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string Name { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_DESCRIPTION, ResourceType = typeof(Resource))]
        public virtual string Description { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_BUILTIN, ResourceType = typeof(Resource))]
        public virtual bool BuiltIn { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_ORGANIZATION_TYPE, ResourceType = typeof(Resource))]
        public virtual OrganizationType OrganizationType { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_CIVIC_ASSOCIATION_REGISTRATION, ResourceType = typeof(Resource))]
        public virtual string CivicAssociationRegistration { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_IC, ResourceType = typeof(Resource))]
        public virtual string Ic { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_EMAIL, ResourceType = typeof(Resource))]
        public virtual string Email { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_FACEBOOK, ResourceType = typeof(Resource))]
        [Url(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_URL_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string Facebook { get; set; }
    }
}
