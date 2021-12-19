using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebProje.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public String Ad { get; set; }
        public String Soyad { get; set; }
        public String Email { get; set; }

        public DateTime DogumTarih { get; set; }
        public DateTime KayitTarih { get; set; }
        public String ResimUrl { get; set; }
        public String Aciklama { get; set; }

        //public int? AuthorityId { get; set; }
        //[ForeignKey("AuthorityId")]
        //public Authority Authority { get; set; }

        public int? CommetId { get; set; }
        [ForeignKey("CommetId")]
        public Comment Comment { get; set; }
    }
}
