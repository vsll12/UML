using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML.Models
{
    internal class Manual
    {
        public string? Title { get; set; }
        public int NumberOfPages { get; set; }
        public string? Language { get; set; }
        public string? Edition { get; set; }
        public DateTime PublicationDate { get; set; }
        public int NumberOfSeats { get; set; }
        public Engine? Engine { get; set; }
    }
}
