using System;
/*
 * Adonis Mendoza
 * 000789894
 * I, Adonis Mendoza, student number 000789894, certify that all code submitted is my own work; that I have not
 * copied it from any other source. I also certify that I have not allowed my work to be copied by others.
 */
namespace Problem3
{
    /// <summary>
    /// Represents a Mail.
    /// </summary>
    public class Mail
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mail" /> class.
        /// </summary>
        public Mail(Sender sender, Receiver receiver, double postalCost, double weight)
        {
            Sender = sender;
            Receiver = receiver;
            PostalCost = postalCost;
            Weight = weight;
        }


        /// <summary>
        /// Gets or sets the sender.
        /// </summary>
        /// <value>The sender.</value>
        public Sender Sender { get; set; }


        /// <summary>
        /// Gets or sets the receiver.
        /// </summary>
        /// <value>The receiver.</value>
        public Receiver Receiver { get; set; }


        /// <summary>
        /// Gets or sets the postalCost.
        /// </summary>
        /// <value>The postal cost.</value>
        public double PostalCost { get; set; }


        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>The weight.</value>
        public double Weight { get; set; }
    }
}
