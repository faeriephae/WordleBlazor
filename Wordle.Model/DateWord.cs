using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Model.Interfaces;

namespace Wordle.Model
{
    public class DateWord : IDateWord
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int WordId { get; set; }

        [Required, Column( TypeName = "DATETIME2" )]
        public DateTime Date { get; set; }
        public Word Word { get; set; }
    }
}
