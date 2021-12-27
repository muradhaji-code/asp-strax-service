using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StraxService.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100), Required(ErrorMessage = "Category name can not be empty")]
        public string Name { get; set; }

        public List<ServiceCategory> ServiceCategories { get; set; }
    }
}
