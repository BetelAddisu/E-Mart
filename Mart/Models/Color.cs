using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mart.Models
{
    public class Color
    {
        [Key]

        public int Id { get; set; }
        [Display(Name ="Picture")]

        public String Picture { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        //Connection

        public List<Color_Item> Colors_Items { get; set; } 

    }
}
