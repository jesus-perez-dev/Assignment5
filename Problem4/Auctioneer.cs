using System;
using System.Collections.Generic;
/*
 * Alexander Islip
 * 000786144
 * I, Alexander Islip, student number 000786144, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */
namespace Problem4
{
    /// <summary>
    /// Auctioneer Class. Implements IObservable interface.
    /// </summary>
    public class Auctioneer : IObservable<AuctionItem>
    {

        /// <summary>
        /// A list of bidders subscribed to the auction.
        /// </summary>
        public List<IObserver<AuctionItem>> bidders;


        /// <summary>
        /// List of items being auctioned off.
        /// </summary>
        public List<AuctionItem> auctionItems;


        /// <summary>
        /// Constructor for an instance of type auctioneer.
        /// </summary>
        public Auctioneer()
        {
            bidders = new List<IObserver<AuctionItem>>();
            auctionItems = new List<AuctionItem>();
        }


        /// <summary>
        /// Subscribe method adds users to bidders list
        /// if not already added.
        /// </summary>
        /// <param name="bidder">The observer, or the "bidder"</param>
        /// <returns>New list with bidder added</returns>
        public IDisposable Subscribe(IObserver<AuctionItem> bidder)
        {
            //Check if bidder is registered. If not, add the bidder.
            if (!bidders.Contains(bidder))
            {
                bidders.Add(bidder);
            }
            return new Unsubscriber<AuctionItem>(bidders, bidder);
        }


        /// <summary>
        /// Gets called when a new bid is placed by
        /// a bidder.
        /// </summary>
        /// <param name="bidder">The bidder who is notifying the auctioneer</param>
        public void ValidateBid(Bidder bidder)
        {
            //check if bidder is subscribed
            if (bidders.Contains(bidder))
            {
                if (bidder.Bid > auctionItems[0].BiddingPrice 
                    && bidder.Bid < auctionItems[0].MaxBidPrice
                    && auctionItems[0].BidsAgainst < 4)
                {
                    auctionItems[0].BiddingPrice = bidder.Bid;
                    auctionItems[0].BidsAgainst += 1;
                    NotifyBidders();

                }
                //if a items bids against reach 5, the item is then sold
                else if (bidder.Bid > auctionItems[0].BiddingPrice 
                    && bidder.Bid < auctionItems[0].MaxBidPrice
                    && auctionItems[0].BidsAgainst == 4)
                {
                    auctionItems[0].BiddingPrice = bidder.Bid;
                    auctionItems[0].BidsAgainst += 1;
                    auctionItems[0].Sold = true;
                    auctionItems[0].SoldTo = bidder.Name;
                    bidders.Remove(bidder);
                    NotifyBidders();
                    auctionItems.RemoveAt(0);
                }
            }
        }


        /// <summary>
        /// Notifies all the bidders when a new bid is
        /// set or the item has been sold.
        /// </summary>
        public void NotifyBidders()
        {
            foreach (Bidder bidder in bidders)
            {
                bidder.OnNext(auctionItems[0]);
            }
        }
    }
}
