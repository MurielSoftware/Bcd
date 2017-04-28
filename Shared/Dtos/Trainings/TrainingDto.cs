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

namespace Shared.Dtos.Trainings
{
    public class TrainingDto : UserDefinableDto
    {
        [Display(Name = MessageKeyConstants.LABEL_DAY, ResourceType = typeof(Resource))]
        public virtual Day Day { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_DATE, ResourceType = typeof(Resource))]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public virtual DateTime Start { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_START, ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string TimeStart { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_END, ResourceType = typeof(Resource))]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public virtual DateTime End { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_END, ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string TimeEnd { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_FOR_CHILDREN, ResourceType = typeof(Resource))]
        public virtual bool ForChildren { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_ADDRESS, ResourceType = typeof(Resource))]
        public virtual string Address { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_CITY, ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string City { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_ZIPCODE, ResourceType = typeof(Resource))]
        public virtual string Zipcode { get; set; }

        public virtual string Gps { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_DESCRIPTION, ResourceType = typeof(Resource))]
        public virtual string Description { get; set; }

        public virtual Guid? UserId { get; set; }
        public virtual Guid? CountryId { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_COUNTRY, ResourceType = typeof(Resource))]
        [Reference(DaoConstants.COUNTRY_ID)]
        public virtual ReferenceString CountryReference { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_TEACHER, ResourceType = typeof(Resource))]
        [Reference(DaoConstants.USER_ID)]
        public virtual ReferenceString UserReference { get; set; }
    }
}
