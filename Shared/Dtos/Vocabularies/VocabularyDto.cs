using Shared.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Vocabularies
{
    public class VocabularyDto : BaseDto
    {
        public virtual string Word { get; set; }
        public virtual string Translate { get; set; }
    }
}
