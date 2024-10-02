using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend03.Models
{
    public class Worker
    {
        public Worker(string name)
        {
            Name = name;
        }

        public Worker()
        {
            
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public Restaurant Restaurant { get; set; }

        public int RestaurantId { get; set; }

        
    }
}
