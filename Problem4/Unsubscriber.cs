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
    /// UnSubscriber class. Implements IDisposable interface.
    /// </summary>
    /// <typeparam name="AuctionItem">Auction item is the class type.</typeparam>
    public class Unsubscriber<AuctionItem> : IDisposable
    {
        /// <summary>
        /// List if IObserver instances.
        /// </summary>
        public List<IObserver<AuctionItem>> _bidders;


        /// <summary>
        /// IObserver Instance.
        /// </summary>
        public IObserver<AuctionItem> _bidder;


        /// <summary>
        /// Unsubscriber constructor.
        /// </summary>
        /// <param name="bidders">List of IObservers</param>
        /// <param name="bidder">IObserver instance</param>
        public Unsubscriber(List<IObserver<AuctionItem>> bidders, IObserver<AuctionItem> bidder)
        {
            _bidders = bidders;
            _bidder = bidder;
        }


        /// <summary>
        /// Dispose removes a IObserver from the
        /// IObserver list when called.
        /// </summary>
        public void Dispose()
        {
            if (_bidders.Contains(_bidder))
            {
                _bidders.Remove(_bidder);
            }
        }
    }
}
