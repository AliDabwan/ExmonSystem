using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class OrderSub
    {
        [Key]
        [ DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }
        public Int64 OrderId { get; set; }

      

    
        public string Note { get; set; }// 

        public int DestinationId { get; set; } //displayNo
        public int AirlineId { get; set; } //displayNo
        public int SubCount { get; set; } = 0; //displayNo







        //public int WashingCounterId { get; set; }




        public int CreatedUserId { get; set; } = Program.userId;


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? LastUpdateDate { get; set; } 
        public int? LastUpdateUserId { get; set; }



        [ForeignKey("CreatedUserId")]
        public virtual User BillCreatedUser { get; set; }

        [ForeignKey("DestinationId")]
        public virtual Destination Destination { get; set; }

        [ForeignKey("AirlineId")]
        public virtual AirLine AirLine { get; set; }

          [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }





    }
}
