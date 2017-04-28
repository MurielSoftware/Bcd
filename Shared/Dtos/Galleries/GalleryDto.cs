using Shared.Core.Constants;
using Shared.Core.Dtos;
using Shared.Core.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Galleries
{
    public class GalleryDto : UserDefinableDto
    {
        [Display(Name = MessageKeyConstants.LABEL_NAME, ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string Name { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_DATE, ResourceType = typeof(Resource))]
        public virtual DateTime Date { get; set; }

        public virtual GalleryType GalleryType { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_DESCRIPTION, ResourceType = typeof(Resource))]
        public virtual string Description { get; set; }

        public virtual Guid? CoverPhotoId { get; set; }
        public virtual Guid? UserDefinableId { get; set; }
    }
}
