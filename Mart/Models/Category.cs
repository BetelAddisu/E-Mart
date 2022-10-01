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

        public String Icon { get; set; }
        public string Name { get; set; }
    }
}
