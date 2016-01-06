using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcInAction.Models
{
    public class Bid
    {
        public DateTime DatePlaced { get; set; }
        public decimal Amount { get; set; }

        public Member Member { get; set; }
    }
}