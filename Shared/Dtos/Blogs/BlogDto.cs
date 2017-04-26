﻿using Shared.Core.Constants;
using Shared.Core.Dtos;
using Shared.Core.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Blogs
{
    public class BlogDto : BaseDto
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
    }
}
