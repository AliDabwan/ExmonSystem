using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class Destination
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReportName { get; set; }
        public bool IsVisa { get; set; } = true;

        public string Sympol { get; set; }
      
       
    }
}
