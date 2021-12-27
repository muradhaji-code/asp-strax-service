using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StraxService.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250), Required(ErrorMessage = "Service should have a picture!")]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [Column(TypeName = "nText"), Required(ErrorMessage = "Service content can not be empty!")]
        public string Content { get; set; }

        [ForeignKey("Client"), Required]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public DateTime CreatedDate { get; set; }

        public List<ServiceCategory> ServiceCategories { get; set; }
    }
}
