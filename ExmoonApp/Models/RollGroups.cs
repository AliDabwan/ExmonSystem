using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class RollGroups
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string GroupRollName { get; set; }

        public virtual ICollection<Rolls> rolls { get; set; }
        public virtual ICollection<User> Users { get; set; }


    }
}
