using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public String Name { get; set; }
        [Range(1, 100)]
        public int DisplayOrder { get; set; }
    }
}
