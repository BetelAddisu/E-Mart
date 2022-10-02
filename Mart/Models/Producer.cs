using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;




namespace Mart.Models
{
    public class Producer
    {
        [Key]

        public int Id { get; set; }

        [Display(Name = "Picture")]
        public String Picture { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Bio")]
        public string Bio { get; set; }

        //CONECTION
        public List<Item> Items { get; set; }
    }

}
