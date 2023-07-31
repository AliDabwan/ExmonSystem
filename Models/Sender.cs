using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class Sender
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PersonName { get; set; }
        public string Phone { get; set; }
        public int No { get; set; }
        public double PriceBaghdadCenter { get; set; } = 0;
        public double PriceBaghdadsuburbs { get; set; } = 0;
        public double PriceOthers { get; set; } = 0;
      

        public Boolean Statue { get; set; } = true;
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime LastUpdateDate { get; set; } = DateTime.Now;
        public int LastUpdateUserId { get; set; } = Program.userId;
        public string LastUpdateUserName { get; set; } = Program.userName;


    }
}
