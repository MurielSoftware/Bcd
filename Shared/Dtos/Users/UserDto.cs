﻿using Shared.Core.Attributes;
using Shared.Core.Constants;
using Shared.Core.Dtos;
using Shared.Core.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Users
{
    public class UserDto : UserDefinableDto
    {
        [Display(Name = MessageKeyConstants.LABEL_TITLE, ResourceType = typeof(Resource))]
        public virtual BujinkanTitle BujinkanTitle { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_FIRST_NAME, ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string FirstName { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_SURNAME, ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string Surname { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_EMAIL, ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        [EmailAddress(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_EMAIL_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string Email { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_PASSWORD, ResourceType = typeof(Resource))]
        public virtual string Password { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_WEB, ResourceType = typeof(Resource))]
        [EmailAddress(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_URL_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string Web { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_FACEBOOK, ResourceType = typeof(Resource))]
        [EmailAddress(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_URL_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string Facebook { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_PHONE, ResourceType = typeof(Resource))]
        public virtual string Phone { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_DAN, ResourceType = typeof(Resource))]
        public virtual short? Dan { get; set; }

        public virtual int Order { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_DESCRIPTION, ResourceType = typeof(Resource))]
        public virtual string Description { get; set; }

        public virtual Guid? CountryId { get; set; }
        public virtual Guid? DojoId { get; set; }
        public virtual Guid RoleId { get; set; }

        [Reference(DaoConstants.COUNTRY_ID)]
        public virtual ReferenceString CountryReference { get; set; }

        [Reference(DaoConstants.DOJO_ID)]
        public virtual ReferenceString DojoReference { get; set; }

        [Reference(DaoConstants.ROLE_ID)]
        public virtual ReferenceString RoleReference { get; set; }

        public virtual bool HasTrainings { get; set; }
    }
}