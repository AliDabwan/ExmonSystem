using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ExmonSystem.Models
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Sympol { get; set; }


    }
}
