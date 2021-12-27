using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StraxService.Models
{
    public class ServiceCategory
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Service"), Required]
        public int ServiceId { get; set; }
        public Service Service { get; set; }

        [ForeignKey("Category"), Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
