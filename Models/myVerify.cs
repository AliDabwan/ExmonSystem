using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class myVerify
    {
        public int Id { get; set; }
        public string AppName { get; set; }
        public string HardId { get; set; }
        public string Serial { get; set; }
        public string IsActivate { get; set; }
        public string ConType { get; set; }
        public string ConName { get; set; }



    }
}
