using Shared.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Questions
{
    public class QuestionDto : BaseDto
    {
        public virtual string QuestionMark { get; set; }
        public virtual string Answer { get; set; }
    }
}
