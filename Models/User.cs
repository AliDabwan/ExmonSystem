using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public string Pwd { get; set; }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string SecurityQuestion { get; set; }
        public string SecurityAnswer { get; set; }

        public Boolean IsEncrept { get; set; }

        public int CashAccountId { get; set; }
        public bool IsHasCashAccount { get; set; }

        public int groupRollId { get; set; }
        public byte[] Image { get; set; }
        [ForeignKey("groupRollId")]
        public virtual RollGroups groupRoll { get; set; }


    }
}
