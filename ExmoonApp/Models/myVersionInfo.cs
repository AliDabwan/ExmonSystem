using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class myVersionInfo
    {

        [Key]
        public int Vno { get; set; }
        public int UpdateNo { get; set; }

        public DateTime UpdateDate { get; set; } = DateTime.Now;
     



    }
}
