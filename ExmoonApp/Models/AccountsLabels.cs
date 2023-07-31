using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class AccountsLabels
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAccountId { get; set; }
        public string MAccountName { get; set; }



    }
}
