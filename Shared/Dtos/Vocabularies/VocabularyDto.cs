using Shared.Core.Dtos;
using Shared.I18n.Constants;
using Shared.I18n.Resources;
using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos.Vocabularies
{
    public class VocabularyDto : BaseDto
    {
        [Display(Name = MessageKeyConstants.LABEL_WORD, ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string Word { get; set; }

        [Display(Name = MessageKeyConstants.LABEL_TRANSLATE, ResourceType = typeof(Resource))]
        [Required(ErrorMessageResourceName = MessageKeyConstants.VALIDATION_REQUIRED_MESSAGE, ErrorMessageResourceType = typeof(Resource))]
        public virtual string Translate { get; set; }
    }
}
