using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class AccountsTransDTO
    {

        public int Id { get; set; }
        public int AccountID { get; set; }
        public string AccountName { get; set; }
        public string TransDay { get; set; }
        public string TransMonth { get; set; }
        public string AccountResName { get; set; }

        public string TransDate { get; set; }

        public int Accounttype { get; set; }
        public string AccountAddress { get; set; }
        public string AccountPhone { get; set; }
        public string AccountTaxNumber { get; set; }
        public double totalDebit { get; set; }
        public double totalCredit { get; set; }
     
        public double totalbalance { get; set; }
        public string VendorType { get; set; }//tawseel,tasleem,both

        public double PriceBaghdadCenterTawseel { get; set; }
        public double PriceBaghdadSuburbTawseel { get; set; }
        public double PriceOthersTawseel { get; set; }

        public double PriceBaghdadCenterTasleem { get; set; }
        public double PriceBaghdadSuburbTasleem { get; set; }
        public double PriceOthersTasleem { get; set; }
        public bool IsEnabled { get; set; } = true;
        public bool IsCustomerRequired { get; set; } = false;
        public bool IsPaymentType { get; set; }


    }
}
