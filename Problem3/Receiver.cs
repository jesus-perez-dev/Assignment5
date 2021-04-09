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
    /// Represents a Receiver.
    /// </summary>
    public class Receiver
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Receiver" /> class.
        /// </summary>
        public Receiver(string name, string address)
        {
            Name = name;
            Address = address;
            
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The Address.</value>
        public string Address { get; set; }
    }
}
