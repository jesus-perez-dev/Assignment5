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
    /// AuctionItem class.
    /// </summary>
    public class AuctionItem
    {

        /// <summary>
        /// Empty constructor for auction item.
        /// </summary>
        public AuctionItem(){}

        /// <summary>
        /// Constructor to create a new item for auction.
        /// </summary>
        /// <param name="biddingPrice">Current bid price.</param>
        /// <param name="maxBidPrice">Max price item can be bidded against</param>
        public AuctionItem(double biddingPrice, double maxBidPrice)
        {
            BiddingPrice = biddingPrice;
            MaxBidPrice = maxBidPrice;
            YearOfCreation = DateTimeOffset.Now.Year;
            BidsAgainst = 0;
            Sold = false;
        }

        /// <summary>
        /// Items starting/current bidding price.
        /// </summary>
        public double BiddingPrice { get; set; }

        /// <summary>
        /// Items max bidding price.
        /// </summary>
        public double MaxBidPrice { get; set; }

        /// <summary>
        /// Year the item was created.
        /// </summary>
        public int YearOfCreation { get; set; }

        /// <summary>
        /// Number of bids against item.
        /// </summary>
        public int BidsAgainst { get; set; }

        /// <summary>
        /// Item's sold status.
        /// </summary>
        public bool Sold { get; set; }

        /// <summary>
        /// The person who the item was sold too.
        /// </summary>
        public string SoldTo { get; set; }
    }
}
