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
        public int CarID { get; set; }
        public string Plaka { get; set; }
        public string Tur { get; set; } //dizel-benzin-hybrid-elektrikli vs...
        public int Yil { get; set; } //Arabanın üretim yılı.
        public int BrandID { get; set; } //iliski sutunu.
        public List<Brand> Brand { get; set; } //Arabanın üretim yılı.
        public Rent Rent { get; set; }
    }
}
