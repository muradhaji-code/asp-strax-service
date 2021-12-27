using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StraxService.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100), Required(ErrorMessage = "Client name can not be empty!")]
        public string FullName { get; set; }

        public List<Service> Services { get; set; }
    }
}
