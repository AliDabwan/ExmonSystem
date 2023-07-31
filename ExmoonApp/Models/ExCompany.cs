using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class ExCompany
    {
        [Key]
        [ DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

      

        public string Name { get; set; }// 
        public string NameEn { get; set; }// 
        public string GoverName { get; set; }// 
        public string DistrictName { get; set; }// 
        public string Address { get; set; }// 
       
        public string PhoneNumber { get; set; }// 
        public string AdminName { get; set; }// 
        public string AdminPhoneNumber { get; set; }// 

        public int DriverId { get; set; } //displayNo
        public int SubscrberId { get; set; } //displayNo



        public double PriceForPassport { get; set; }
        public bool Statu { get; set; } = true;





        //public int WashingCounterId { get; set; }




        public int CreatedUserId { get; set; } = Program.userId;


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? LastUpdateDate { get; set; } 
        public int? LastUpdateUserId { get; set; }



        [ForeignKey("CreatedUserId")]
        public virtual User BillCreatedUser { get; set; }

        [ForeignKey("DriverId")]
        public virtual Driver Driver { get; set; }

        [ForeignKey("SubscrberId")]
        public virtual Subscriber Subscriber { get; set; }





    }
}
