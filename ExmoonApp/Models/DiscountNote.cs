using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class DiscountNote
    {
        [Key]
        [ DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NoteId { get; set; }

        [Required]
        [StringLength(100)]
        public string NoteType { get; set; }//debit ,Credit
        [StringLength(100)]
        public string NoteTypeAr { get; set; }//sils ,purchasee
       

        public int RefId { get; set; } //displayNo
        public int RefNo { get; set; } //displayNo

        [Column(TypeName = "DateTime"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:MM}")]

        public DateTime? RefDate { get; set; } //= DateTime.Now;

        [Column(TypeName = "DateTime"), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:MM}")]

        public DateTime NoteDate { get; set; } //= DateTime.Now;

        public string AttachmentName { get; set; }// FILE
        [StringLength(50)]
        public string AttachmentType { get; set; }// FILE
        public byte[] AttachmeedFile { get; set; }

        public int CusOrSuplierAccountId { get; set; }//f
        public string CusOrSuplierAccountName { get; set; }// 


        public string NoteNote { get; set; }// details

        public int DiscountAccountId { get; set; }
        public string DiscountAccountName { get; set; }
        public int VatAccountId { get; set; }
        public string VatAccountName { get; set; }
        


       

        public double TotalAmmount { get; set; }
        public double TotalVat { get; set; }
     
        public double TotalNet { get; set; }

        public string TotalNetWords { get; set; }
        public bool IsVatInclud { get; set; }


        public int NoteCreatedUserId { get; set; } = Program.userId;


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime NoteCreatedDate { get; set; } = DateTime.Now;

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? NoteLastUpdateDate { get; set; }
        public int? NoteLastUpdateUserId { get; set; } 


        [ForeignKey("NoteCreatedUserId")]
        public virtual User NoteCreatedUser { get; set; }
        [ForeignKey("CusOrSuplierAccountId")]
        public virtual Accounts CusOrSuplierAccounts { get; set; }

        [ForeignKey("DiscountAccountId")]
        public virtual Accounts DiscountAccounts { get; set; }

        [ForeignKey("VatAccountId")]
        public virtual Accounts VatAccounts { get; set; }


    }
}
