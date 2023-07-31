using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class ExCompanyDTO
    {
        public int Id { get; set; }

      

        public string Name { get; set; }// 
      


        public double PriceForPassport { get; set; }
        public int SubscrberId { get; set; } //displayNo

        public string Address { get; set; }// 

        public string PhoneNumber { get; set; }// 
        public string Statue { get; set; }// 
        public int OrderCount { get; set; } 
        public double TotalAmount { get; set; }
        public double TotalPaid { get; set; }
        public double Balance { get; set; }
    }
}
