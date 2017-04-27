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

namespace Shared.Dtos.Events
{
    public abstract class BaseEventDto : UserDefinableDto
    {
        [Display(Name = MessageKeyConstants.LABEL_THEME, ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string Theme { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_START, ResourceType = typeof(Resource))]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public virtual DateTime Start { get; set; }

        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string TimeStart { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_END, ResourceType = typeof(Resource))]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy HH:mm}", ApplyFormatInEditMode = true)]
        public virtual DateTime End { get; set; }

        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string TimeEnd { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_ADDRESS, ResourceType = typeof(Resource))]
        public virtual string Address { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_CITY, ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string City { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_ZIPCODE, ResourceType = typeof(Resource))]
        public virtual string Zipcode { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_GPS, ResourceType = typeof(Resource))]
        public virtual string Gps { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_FACEBOOK, ResourceType = typeof(Resource))]
        public virtual string Facebook { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_DESCRIPTION, ResourceType = typeof(Resource))]
        public virtual string Description { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_SHOW_PRIZE, ResourceType = typeof(Resource))]
        public virtual bool ShowPrize { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_PRIZE_MEMBER, ResourceType = typeof(Resource))]
        public virtual short? PrizeMember { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_PRIZE_NOMEMBER, ResourceType = typeof(Resource))]
        public virtual short? PrizeNomember { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_CURRENCY, ResourceType = typeof(Resource))]
        public virtual Currency Currency { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_ENABLE_REGISTRATION, ResourceType = typeof(Resource))]
        public virtual bool EnableRegistration { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_REGISTRATION_DEADLINE, ResourceType = typeof(Resource))]
        public virtual DateTime? RegistrationDeadline { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_CURRENT_PARTICIPIANTS, ResourceType = typeof(Resource))]
        public virtual int CurrentParticipiants { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_MAXIMUM_PARTICIPIANTS, ResourceType = typeof(Resource))]
        public virtual int? MaximumParticipiants { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_PREPAYMENT, ResourceType = typeof(Resource))]
        public virtual short? Prepayment { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_PREPAYMENT_DEADLINE, ResourceType = typeof(Resource))]
        public virtual DateTime? PrepaymentDeadline { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_ACCOUNT_NUMBER, ResourceType = typeof(Resource))]
        public virtual string AccountNumber { get; set; }

        public virtual Guid? CountryId { get; set; }

        [Reference(DaoConstants.COUNTRY_ID)]
        public virtual ReferenceString CountryReference { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_TEACHERS, ResourceType = typeof(Resource))]
        [Reference(DaoConstants.ATTRIBUTE_USERS)]
        //[ReferenceRequiredValidator(ErrorMessageResourceName = MessageKeys.REQUIRED, ErrorMessageResourceType = typeof(Resource))]
        public virtual ReferenceString UsersReference { get; set; }
    }
}
