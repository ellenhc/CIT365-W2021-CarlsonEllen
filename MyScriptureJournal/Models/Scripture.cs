using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ID { get; set; } //The database's primary key
        public string Title { get; set; }
        public DateTime DateAdded { get; set; }
        public string Note { get; set; }
    }
}
