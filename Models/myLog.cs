using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class myLog
    {
        public string ErrorDetails { get; set; }
        public DateTime ErrDate { get; set; } = DateTime.Now;
        



    }
}
