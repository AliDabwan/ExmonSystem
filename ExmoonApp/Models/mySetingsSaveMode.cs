using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class mySetingsSaveMode
    {
        public Boolean IsInitialize { get; set; }
        public string PropActv { get; set; }
        public string PropVerisonSleep { get; set; }
        public string Propfree { get; set; }
        public string ConType { get; set; }
        public string ConName { get; set; }



    }
}
