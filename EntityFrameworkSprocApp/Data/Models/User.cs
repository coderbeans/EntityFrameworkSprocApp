using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkSprocApp.Data.Models
{
    /// <summary>
    /// The user EF model class
    /// </summary>
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Guid { get; set; }

        public string Name { get; set; }

        public DateTime? DOB { get; set; }

        public Gender? Gender { get; set; }
    }

    public enum Gender
    {
        Female = 0,
        Male    
    }
}
