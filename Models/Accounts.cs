using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class Accounts
    {
        [Key]
        public int Id { get; set; }
        public int AccountID { get; set; }
        public int Accounttype { get; set; }

        public string AccountName { get; set; }
        public string AccountResName { get; set; }

        public string Address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        
        public string note { get; set; }
        
        public string mobile { get; set; }
        public string taxnumber { get; set; }

        public double creditlimit { get; set; }
        public double balance { get; set; }

        public string VendorType { get; set; }//tawseel,tasleem,both

        public double PriceBaghdadCenterTawseel { get; set; }
        public double PriceBaghdadSuburbTawseel { get; set; }
        public double PriceOthersTawseel { get; set; }

        public double PriceBaghdadCenterTasleem { get; set; }
        public double PriceBaghdadSuburbTasleem { get; set; }
        public double PriceOthersTasleem { get; set; }


        public bool IsEnabled { get; set; } = true;
        public bool IsCustomerRequired { get; set; } = false;
        public bool IsPaymentType { get; set; } = false;
        public bool IsHasTax { get; set; } = false;

        public int MAccountLabelId { get; set; }

        [ForeignKey("MAccountLabelId")]
        public virtual AccountsLabels AccountsLabel { get; set; }
        public virtual ICollection<AccountsTransactionSub> acctransnSub { get; set; }



    }
}
