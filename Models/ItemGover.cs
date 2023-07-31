using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class ItemGover
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int GoverType { get; set; } = 2;

        public string Sympol { get; set; }
      
       
    }
}
