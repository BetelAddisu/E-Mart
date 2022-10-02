using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Mart.Models
{
    public class Category
    {
        [Key]

        public int Id { get; set; }

        [Display(Name = "Icon")]
        public String Icon { get; set; }
        

        [Display(Name = "Name")]
        public string Name { get; set; }

        //CONNECTION

        public List<Item> Items { get; set; }

    }
}
