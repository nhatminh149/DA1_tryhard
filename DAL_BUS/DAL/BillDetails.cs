using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.DAL
{
    public class BillDetails
    {
        [Key]
        public Guid Id { get; set; }
        public Guid BillId { get; set; }
        public Guid ProductId { get; set; }
        public long Price {  get; set; }
        public int Amount { get; set; }
        //Navi
        public virtual Bill Bill { get; set; }
        public virtual Product Product { get; set; }
    }
}
