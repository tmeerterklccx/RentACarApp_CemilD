using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Car
    {
        [Key]
        public int ArabaID { get; set; }
        public string Plaka { get; set; }
        public string Tur { get; set; } //dizel-benzin-hybrid-elektrikli vs...
        public int Yil { get; set; } //Arabanın üretim yılı.
        public required Brand ID { get; set; } //Arabanın üretim yılı.
    }
}
