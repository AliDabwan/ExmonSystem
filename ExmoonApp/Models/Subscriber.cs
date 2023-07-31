using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class Subscriber
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public double Price { get; set; }

        public bool IsPassport { get; set; } = false;
        public bool IsTicket { get; set; } = false;
        public bool IsVisa { get; set; } = false;
        public bool IsExcell { get; set; } = false;
        public bool IsVoucher { get; set; } = false;



    }
}
