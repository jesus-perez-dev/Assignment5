using System;
using System.Collections.Generic;
using System.Text;
/*
 * Alexander Islip
 * 000786144
 * I, Alexander Islip, student number 000786144, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */
namespace Problem4
{
    /// <summary>
    /// Bidder class. Implements the IObserver interface.
    /// </summary>
    public class Bidder : IObserver<AuctionItem>
    {
        /// <summary>
        /// Constructor to create a new Bidder instance.
        /// </summary>
        /// <param name="name">The Bidders name</param>
        public Bidder(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Bidder must supply a name!");
            }
            Name = name;
        }


        /// <summary>
        /// Bidders name.
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// Bidders bid.
        /// </summary>
        public double Bid { get; set; }


        /// <summary>
        /// Registration Instance.
        /// </summary>
        public static IDisposable Registration { get; set; }


        /// <summary>
        /// Subscribes the user to the auction.
        /// </summary>
        /// <param name="auctioneer">The auction's auctioneer.</param>
        public void Subscribe(Auctioneer auctioneer)
        {
            Registration = auctioneer.Subscribe(this);
        }


        /// <summary>
        /// Calls the Unsubscribe interface to be removed 
        /// from the auction.
        /// </summary>
        public void Unsubscribe()
        {
            Registration.Dispose();
        }

        /// <summary>
        /// When complete, unsubscribe the bidder.
        /// </summary>
        public void OnCompleted()
        {
            Unsubscribe();
        }

        /// <summary>
        /// OnError is called by the auctioneer if
        /// any error occurs.
        /// </summary>
        /// <param name="error"></param>
        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Called to notify the observers the status
        /// of the auctioned item.
        /// </summary>
        /// <param name="item"></param>
        public void OnNext(AuctionItem item)
        {
            if (!item.Sold)
            {
                Console.WriteLine($"New highest Bid! New Bid Price: {item.BiddingPrice}");
            }
            else if(item.Sold)
            {
                Console.WriteLine($"The item has been sold to {item.SoldTo} at the price ${item.BiddingPrice}");
                if (item.SoldTo.Equals(Name))
                {
                    OnCompleted();
                }
            }
        }


        /// <summary>
        /// Sets the new bid. Notifies the auctioneer.
        /// </summary>
        /// <param name="bid">Bidders bid</param>
        /// <param name="auctioneer">Auctioneer to notify</param>
        public void GiveNewBid(double bid, Auctioneer auctioneer)
        {
            Bid = bid;
            NotifyAuctioneer(auctioneer);
        }


        /// <summary>
        /// Notifies the auctioneer to validate new bid.
        /// </summary>
        /// <param name="auctioneer">Auctioneer to notify</param>
        public void NotifyAuctioneer(Auctioneer auctioneer)
        {
            auctioneer.ValidateBid(this);
        }
    }
}
