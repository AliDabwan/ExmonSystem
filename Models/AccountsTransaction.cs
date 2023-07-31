using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIGAPOS.Models
{
   public class AccountsTransaction
    {
        [Key]
        public int TransId { get; set; }

        public int AccountID { get; set; }
        public string AccountName { get; set; }
        public string TransType { get; set; }
        public int TransTypeId { get; set; }
        public string TransrefNo { get; set; }

        public string note { get; set; }

        public double Amount { get; set; }

        public string AmountText { get; set; } 


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime TransDate { get; set; } = DateTime.Now;


        public int UserId { get; set; }


        [ForeignKey("AccountID")]
        public virtual Accounts Account { get; set; }



        [ForeignKey("UserId")]
        public virtual User User { get; set; }

    }
}
