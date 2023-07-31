using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class AccountsTransactionSub
    {
        [Key]
        [ DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TransId { get; set; }
     
       [Required]
        [StringLength(100)] 
        public string TransRefType { get; set; }//bill ,voucher name
        [Required]
        [StringLength(100)]
        public string TransRefTypeAr { get; set; }//bill ,voucher name
        [Required]
        public double TransRefId { get; set; }//billid ,voucherid,entryid
        [StringLength(200)]
        public string TransRefNo { get; set; }//billidNo ForUser

        public string AttachmentName { get; set; }// FILE
        [StringLength(50)]
        public string AttachmentType { get; set; }// FILE
        public byte[] AttachmeedFile { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime TransDate { get; set; } //= DateTime.Now;


        public int UserId { get; set; } = Program.userId;
        public int CusSubId { get; set; }
        public int GroupId { get; set; }

        public int EntryId { get; set; }//id if entry ,id of voucher

        public string DetailsNote { get; set; }
        public int ObsitAccountID { get; set; }
        public string ObsitAccountName { get; set; }

        public int AccountID { get; set; }
        public string AccountName { get; set; }
        [StringLength(10)]
        public string EntryType { get; set; }//debit/credit from,to


        public double FromAmount { get; set; }
        public double ToAmount { get; set; }

        public string AmountText { get; set; }
        public string Details { get; set; }




        [ForeignKey("AccountID")]
        public virtual Accounts Account { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }


    }
}
