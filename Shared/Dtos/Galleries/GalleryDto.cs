using Shared.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Galleries
{
    public class GalleryDto : BaseDto
    {
        public virtual string Name { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual GalleryType GalleryType { get; set; }
        public virtual string Description { get; set; }

        public virtual Guid? CoverPhotoId { get; set; }
        public virtual Guid? UserDefinableId { get; set; }
    }
}
