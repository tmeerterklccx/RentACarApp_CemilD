using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Rent
    {
        [Key]
        public int RentID { get; set; }
        public int UserID { get; set; }
        public int CarID { get; set; }

        public virtual User User { get; set; }
        public virtual Car Car { get; set; }
        public DateTime Verilis_Tarihi { get; set; }
        public DateTime Teslim_Tarihi { get; set; }
        public double Ucret { get; set; }
        public bool Statu { get; set; }
    }
}
