using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class AccountsVendor
    {
        [Key]
        public int Id { get; set; }
        public int AccountID { get; set; }

        public string AccountName { get; set; }

      
        public string phone { get; set; }
      
        


    }
}
