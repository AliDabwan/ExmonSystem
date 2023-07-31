using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class Company
    {
        [Key]
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string DetailsAr { get; set; }
        public string DetailsEn { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Phone3 { get; set; }
        public string Email { get; set; }
        public string AdressAr { get; set; }
        public string AdressEn { get; set; }
        public string TaxNumber { get; set; }
        public Byte[] Image { get; set; }

         
        public bool AllowSaleNegativeQty { get; set; }
        public bool AllowSaleUnderCost { get; set; }
        public bool AllowSaleUnderLessPrice { get; set; }

        public bool AllowBillEditDate { get; set; }
        public bool AllowBillPurchaseEditDate { get; set; }

        public bool ShowSerialColumn { get; set; }
        public bool ShowDiscountColumn { get; set; }



        public bool SalesAppTax { get; set; }
        public bool PurchaseAppTax { get; set; }
        public decimal PropValueTaxSales { get; set; } = 0;

        public decimal PropValueTaxPurchase { get; set; }





        public bool CostUpdateWithPurchase { get; set; }
        public bool PricesUpdateWithPurchase { get; set; }

        public bool PropUseMizan { get; set; }

        public int PropMizanType { get; set; } = 1;

        public int PropMizanStarts { get; set; }
        public int PropMizanLength { get; set; }
        public int PropMizanStartLength { get; set; }

        public int PropMizanQtyStarts { get; set; }
        public int PropMizanQtyLength { get; set; }
        public int PropMizanQtyDecimel { get; set; }


        public bool UserDiscountBeforTaxBillNet { get; set; }


        public bool ChangePOSButtonToTouchPos { get; set; }
        public bool UseWorkDay { get; set; }
        public bool UseResurantMode { get; set; }
        public int ResetTalapInEndDay { get; set; }

        public bool UseSectionPrinter { get; set; }
        public int TalapPrintBy { get; set; }//0by section 1 by printer       


        public int PropAccAtmAccountId { get; set; }

        public int PropAccNoteDebitId { get; set; }
        public int PropAccNoteDebitDiscountId { get; set; }
        public int PropAccNoteCreditId { get; set; }

        public int PropAccNoteCreditDiscountId { get; set; }

        public bool AllowRepeatItemsInBill { get; set; } = false;


    }
}
