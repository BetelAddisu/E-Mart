using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Mart.Data.Enum;


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

        //CONNECTION

        public List<Color_Item> Colors_Items { get; set; }

        //CATEGORY
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProduceryId")]
        public Category Producer { get; set; }

        

    }
}
