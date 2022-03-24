using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebScrapping.Models
{
    public class Tender
    {
        public string Title { get; set; }
        public string Ref { get; set; }
        public DateTime ClosingDate { get; set; }
        public DateTime BidOpenDate { get; set; }
    }
}
