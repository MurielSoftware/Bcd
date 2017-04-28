using Shared.Dtos.Galleries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    [Table("GALLERY")]
    public class Gallery : UserDefinable
    {
        [Required]
        public virtual string Name { get; set; }

        public virtual DateTime Date { get; set; }
        public virtual GalleryType GalleryType { get; set; }
        public virtual string Description { get; set; }

        public virtual Guid? CoverPhotoId { get; set; }
        public virtual Guid? UserDefinableId { get; set; }

        [ForeignKey("CoverPhotoId")]
        public virtual Resource CoverPhoto { get; set; }

        [ForeignKey("UserDefinableId")]
        public virtual UserDefinable UserDefinable { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
