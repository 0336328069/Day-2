using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class UserViewModel
    {
        public string username { get; set; }
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
