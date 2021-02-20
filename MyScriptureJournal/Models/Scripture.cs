using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; } //The database's primary key
        public string Book { get; set; }
        public string Chapter { get; set; }
        public string Verse { get; set; }

        [Display(Name = "Scripture Reference")]
        public string Reference
        {
            get
            {
                return Book + " " + Chapter + ":" + Verse;
            }
        }

        [Display(Name = "Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }
        public string Note { get; set; }
    }
}
