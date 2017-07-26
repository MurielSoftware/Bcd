using Shared.Core.Dtos;
using Shared.I18n.Constants;
using Shared.I18n.Resources;
using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos.Questions
{
    public class QuestionDto : BaseDto
    {
        [Display(Name = MessageKeyConstants.LABEL_QUESTION, ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string QuestionMark { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_ANSWER, ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string Answer { get; set; }
    }
}
