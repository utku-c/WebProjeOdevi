using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models
{
    public class Content
    {
        public int Id { get; set; }
        public String KonuBasligi { get; set; }
        public String Icerik { get; set; }
        public String Aciklama { get; set; }
        public String ContentResimUrl { get; set; }

        
        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Kategori Category { get; set; }

    }
}
