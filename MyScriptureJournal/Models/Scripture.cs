using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; } //The database's primary key

        [Display(Name = "Scripture Reference")]
        public string Title { get; set; }

        [Display(Name = "Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
        public string Note { get; set; }
    }
}
