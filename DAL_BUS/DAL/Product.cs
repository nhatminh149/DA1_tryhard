using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BUS.DAL
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public string Details {  get; set; }
        public string ImgURL { get; set; }
        public string From { get; set; } //Xuất xứ
        public long Price { get; set; }
        public int TotalAmount { get; set; }
        public int Status { get; set; }
        public Guid? SaleId { get; set; }
        //Navigation
        public virtual List<BillDetails> BillDetails { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
