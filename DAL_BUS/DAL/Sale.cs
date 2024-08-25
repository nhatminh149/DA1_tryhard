using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.DAL
{
    public class Sale
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Percent { get; set; } //Giảm giá
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Status {  get; set; }
         //Navi
         public virtual List<Product> Products { get; set; }
    }
}
