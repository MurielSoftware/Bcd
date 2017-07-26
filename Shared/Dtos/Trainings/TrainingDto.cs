using Shared.Core.Attributes;
using Shared.Core.Constants;
using Shared.Core.Dtos;
using Shared.I18n.Constants;
using Shared.I18n.Resources;
using System;
using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos.Trainings
{
    public class TrainingDto : UserDefinableDto
    {
        [Display(Name = MessageKeyConstants.LABEL_DAY, ResourceType = typeof(Resource))]
        public virtual Day Day { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_START, ResourceType = typeof(Resource))]
        public virtual DateTime Start { get; set; }
    
        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string TimeStart { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_END, ResourceType = typeof(Resource))]
        public virtual DateTime End { get; set; }

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

        [Reference(DaoConstants.COUNTRY_ID)]
        public virtual ReferenceString CountryReference { get; set; }

        [Reference(DaoConstants.USER_ID)]
        public virtual ReferenceString UserReference { get; set; }
    }
}
