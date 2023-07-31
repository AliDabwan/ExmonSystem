using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
    public class BillsProfitTaxDTO
    {
        public int BillId { get; set; }

        public int BillNo { get; set; }

        public string BillType { get; set; }
        public string BillTypeAr { get; set; }

        public string CustomerSuplierName { get; set; }
        public string CustomerSuplierTaxNo { get; set; }
        public string BillPayMethod { get; set; }
        public DateTime BillDate { get; set; }
        public string BillDayDate { get; set; }

        public double BillCost { get; set; }
        public double BillCostVat { get; set; }

        public double BillTotal { get; set; }

        public double BillDiscount { get; set; }

        public double BillVat { get; set; }

        public double BillProfit
        {
            get;

            set;
        }
        public double BillNet { get; set; }



    }
}
