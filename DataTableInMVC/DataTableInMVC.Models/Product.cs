using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableInMVC.Models
{
    
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }        
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public decimal? Price { get; set; }
        public int Quantity { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

    }
}
