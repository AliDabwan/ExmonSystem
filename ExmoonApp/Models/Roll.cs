using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmonSystem.Models
{
   public class Rolls
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RollTitle { get; set; }

        public int groupRollId { get; set; }

        [StringLength(10)]
        public string IsChecked { get; set; } = "False";
        [ForeignKey("groupRollId")]
        public virtual RollGroups rollGroup { get; set; }


    }
}
