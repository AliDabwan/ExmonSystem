using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class Joined
    {
        [Key]
        public int Id { get; set; }
        public string UriPath { get; set; }

        public int VId { get; set; }

      


    }
}
