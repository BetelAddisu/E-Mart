using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Mart.Data;

;
namespace Mart.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
         
        public string Name { get; set; }
        [Required]  

        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime ManufacturedDate { get; set; }
        public DateTime ExprirationDate { get; set; }
        public ItemCategory ItemCategory { get; set; }

    }
}
