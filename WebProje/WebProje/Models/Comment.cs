using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public String Yorum { get; set; }
        public int YorumPuan { get; set; }
        public DateTime YorumTarih { get; set; }

        public int? ContentId { get; set; }
        [ForeignKey("ContentId")]
        public Content Content { get; set; }
    }
}
