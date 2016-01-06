using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcInAction.Models
{
    public class Item
    {
        public int ItemID { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime AuctionDate { get; set; }

        public List<Bid> Bids { get; set; }

        public Item()
        {
            Bids = new List<Bid>();
        }

        public void AddBid(Member member, decimal amount)
        {
            if (Bids.Count()==0 || amount>Bids.Max(m=>m.Amount))
            {
                Bids.Add(new Bid
                {
                    Amount = amount,
                    Member = member,
                    DatePlaced = DateTime.Now
                });
            }
            else
            {
                throw new InvalidOperationException("Bid amount to low");
            }
            
        }
    }
}