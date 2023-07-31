﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class Order
    {
        [Key]
        [ DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }

      

    
        public string Note { get; set; }// 

        public int DriverId { get; set; } //displayNo
        public int ExCompanyId { get; set; } //displayNo
        public int OrderCount { get; set; } = 0; //displayNo



        public double Price { get; set; }
        public double TotalAmount { get; set; }
        public double TotalPaid { get; set; }
        public bool IsPrinted { get; set; } = false;
        public bool IsPaid { get; set; } = false;

        public string PaidStatue { get; set; } = "غيرمسدد";
        public string PrintedStatue { get; set; } = "غيرمطبوع";




        //public int WashingCounterId { get; set; }




        public int CreatedUserId { get; set; } = Program.userId;


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? LastUpdateDate { get; set; } 
        public int? LastUpdateUserId { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTime?PaidDate { get; set; }


        [ForeignKey("CreatedUserId")]
        public virtual User BillCreatedUser { get; set; }

        [ForeignKey("DriverId")]
        public virtual Driver Driver { get; set; }

        [ForeignKey("ExCompanyId")]
        public virtual ExCompany ExCompany { get; set; }

        public virtual ICollection<OrderSub> OrderSubs { get; set; }




    }
}
