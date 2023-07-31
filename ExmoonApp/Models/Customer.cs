using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class Customer
    {
        [Key]
        [ DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public Int64 No { get; set; } //displayNo
      
        public string Barcode { get; set; } //displayNo



        public string AttachmentName { get; set; }// FILE
        [StringLength(50)]
        public string AttachmentType { get; set; }// FILE
        public byte[] AttachmeedFile { get; set; }



        public string FirstName { get; set; }// 
        public string SecondName { get; set; }// 
        public string LastName { get; set; }// 
        public string FamilyName { get; set; }// 
        public string EnName { get; set; }// 
        public string FullName { get; set; }// 
        public string Gender { get; set; }// 
        public string Job { get; set; }// 
        public string MotherName { get; set; }// 
        public string PhoneNumber { get; set; }// 
        public string PassportNo { get; set; } //displayNo


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime IssuedDate { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime ExpierDate { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        public DateTime BirthDate { get; set; }









        //public int WashingCounterId { get; set; }




        public int CreatedUserId { get; set; } = Program.userId;


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? LastUpdateDate { get; set; } 
        public int? LastUpdateUserId { get; set; }



        [ForeignKey("CreatedUserId")]
        public virtual User BillCreatedUser { get; set; }

        
       


    }
}
