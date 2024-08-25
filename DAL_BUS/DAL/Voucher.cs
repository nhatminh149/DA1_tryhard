using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.DAL
{
    public class Voucher
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Value { get; set; } // Tiền  giảm
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Status { get; set; }
        //Navi
        public virtual List<Bill> Bills { get; set; }
    }
}
