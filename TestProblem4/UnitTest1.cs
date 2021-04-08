using NUnit.Framework;
using Problem4;
/*
 * Alexander Islip
 * 000786144
 * I, Alexander Islip, student number 000786144, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */
namespace TestProblem4
{
    /// <summary>
    /// Tests for problem 4.
    /// </summary>
    public class Tests
    {
        Auctioneer auctioneer; //auctioneer instance
        Bidder bidderOne;      //bidder instance
        Bidder bidderTwo;      //bidder instance
        Bidder bidderThree;    //bidder instance
        Bidder bidderFour;     //bidder instance

        /// <summary>
        /// Setup for the tests.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            //Create auctioneer instance.
            auctioneer = new Auctioneer();
            //Add items to be sold.
            auctioneer.auctionItems.Add(new AuctionItem(20.0, 500.0));
            auctioneer.auctionItems.Add(new AuctionItem(100.0, 200.0));
            auctioneer.auctionItems.Add(new AuctionItem(400.0, 2000.0));
            //Create bidder instances.
            bidderOne = new Bidder("Alex");
            bidderTwo = new Bidder("Amar");
            bidderThree = new Bidder("Mel");
            bidderFour = new Bidder("Mohamed");
        }


        /// <summary>
        /// Tests if bidders can subscribe and
        /// unsubscribe at any given time.
        /// </summary>
        [Test]
        public void SubscribeUnSubscribe()
        {
            //Initial Assert
            Assert.AreEqual(0, auctioneer.bidders.Count);

            //Subscribing bidders to auction.
            bidderOne.Subscribe(auctioneer);
            bidderTwo.Subscribe(auctioneer);
            bidderThree.Subscribe(auctioneer);
            bidderFour.Subscribe(auctioneer);

            //Unsubscribe one bidder
            bidderOne.Unsubscribe();

            //Assert
            //expected bidders list count againsr actual
            Assert.AreEqual(3, auctioneer.bidders.Count);
        }


        /// <summary>
        /// Testing if a bidder unsubscribes 
        /// when she/he wins an auctioned item
        /// </summary>
        [Test]
        public void HighestBidUnsubscribes()
        {

            //Subscribing bidders to auction.
            bidderOne.Subscribe(auctioneer);
            bidderTwo.Subscribe(auctioneer);
            bidderThree.Subscribe(auctioneer);
            bidderFour.Subscribe(auctioneer);

            //Simulate bidding in auction.
            bidderOne.GiveNewBid(30.0, auctioneer);
            bidderTwo.GiveNewBid(70.0, auctioneer);
            bidderFour.GiveNewBid(100.0, auctioneer);
            bidderThree.GiveNewBid(120.0, auctioneer);
            bidderTwo.GiveNewBid(125.0, auctioneer);

            //Bidder who won must be unsubscribed from auction.
            bool bidderSubscribed = false;

            //If found, bidder is still subscribed.
            foreach (Bidder bidder in auctioneer.bidders)
            {
                if (bidder.Name.Equals(bidderTwo.Name))
                {
                    bidderSubscribed = true;
                }
            }
            //Assert
            Assert.IsFalse(bidderSubscribed);
        }


        /// <summary>
        /// Testing if item is removed from list
        /// once sold to a bidder.
        /// </summary>
        [Test]
        public void ItemsGetRemovedFromList()
        {

            //Subscribing bidders to auction.
            bidderOne.Subscribe(auctioneer);
            bidderTwo.Subscribe(auctioneer);
            bidderThree.Subscribe(auctioneer);
            bidderFour.Subscribe(auctioneer);

            //Auction starts x number items
            Assert.AreEqual(3, auctioneer.auctionItems.Count);

            //Simulate bidding in auction.
            bidderOne.GiveNewBid(30.0, auctioneer);
            bidderTwo.GiveNewBid(70.0, auctioneer);
            bidderFour.GiveNewBid(100.0, auctioneer);
            bidderThree.GiveNewBid(120.0, auctioneer);
            bidderTwo.GiveNewBid(125.0, auctioneer);

            //Auction ends with x-1 items.
            Assert.AreEqual(2, auctioneer.auctionItems.Count);

        }


        /// <summary>
        /// Tests if a bidder can bid over the max
        /// allowed bid. Bidder should not be able to.
        /// </summary>
        [Test]
        public void BidHigherMaxBid()
        {

            //Subscribing bidders to auction.
            bidderOne.Subscribe(auctioneer);
            bidderTwo.Subscribe(auctioneer);
            bidderThree.Subscribe(auctioneer);
            bidderFour.Subscribe(auctioneer);

            //Simulate bidding in auction.
            bidderOne.GiveNewBid(100.0, auctioneer);
            bidderTwo.GiveNewBid(250.0, auctioneer);
            bidderFour.GiveNewBid(400.0, auctioneer);
            bidderThree.GiveNewBid(450.0, auctioneer);

            //Bid higher than max bid
            bidderTwo.GiveNewBid(550.0, auctioneer);

            //Items list should contain all items
            Assert.AreEqual(3, auctioneer.auctionItems.Count);

        }
    }
}