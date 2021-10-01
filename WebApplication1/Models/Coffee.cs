using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Coffee
    {
        [Key]
        public int ID { get; set; }
        public string Image { get; set; }
        public string name { get; set; }
        public int Price { get; set; }
        public Coffee(int id,string img,string n,int price) {
            ID = id;
            Image = img;
            name = n;
            Price = price;
        }
    }
}
